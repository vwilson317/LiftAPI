using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsumerService
{
    public partial class Service1 : ServiceBase
    {
        private static Timer _timer;

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool SetServiceStatus(IntPtr handle, ref ServiceStatus serviceStatus);

        private String _hostName = ConfigurationManager.AppSettings["RabbitMq"];
        private String _userName = ConfigurationManager.AppSettings["GenericUser"];
        private String _password = ConfigurationManager.AppSettings["GenericPassword"];
        private EventLog _eventLog1;
        private ServiceStatus _serviceStatus;


        public Service1()
        {
            InitializeComponent();
            _eventLog1 = new EventLog();
            if (!EventLog.SourceExists("MySource"))
            {
                EventLog.CreateEventSource(
                    "MySource", "MyNewLog");
            }
            _eventLog1.Source = "MySource";
            _eventLog1.Log = "MyNewLog";

            _timer = new Timer();
        }

        //public MyNewService(string[] args)
        //{
        //    InitializeComponent();
            //string eventSourceName = "MySource";
            //string logName = "MyNewLog";
            //if (args.Count() > 0)
            //{
            //    eventSourceName = args[0];
            //}
            //if (args.Count() > 1) { logName = args[1]; }
            //eventLog1 = new System.Diagnostics.EventLog();
            //if (!System.Diagnostics.EventLog.SourceExists(eventSourceName))
            //{
            //    System.Diagnostics.EventLog.CreateEventSource(eventSourceName, logName);
            //}
            //eventLog1.Source = eventSourceName;
            //eventLog1.Log = logName;
        //}

        protected override void OnStart(string[] args)
        {
            // Set up a timer to trigger every minute.
            _timer.Enabled = true;
            _timer.Interval = 60000; // 60 seconds
            _timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
            _timer.Start();

            var factory = new ConnectionFactory()
            {
                HostName = _hostName,
                UserName = _userName,
                Password = _password
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "", type: "fanout");

                var queueName = channel.QueueDeclare().QueueName;
                channel.QueueBind(queue: queueName,
                    exchange: "",
                    routingKey: "api");

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    Console.WriteLine(" [x] {0}", message);
                };

                channel.BasicConsume(queue: queueName,
                    noAck: true,
                    consumer: consumer);
            }

            // Update the service state to Running.
            _serviceStatus = new ServiceStatus();
            _serviceStatus.dwCurrentState = ServiceState.SERVICE_RUNNING;
            SetServiceStatus(this.ServiceHandle, ref _serviceStatus);
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            // TODO: Insert monitoring activities here.
            _eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            _eventLog1.WriteEntry("In onStop.");
            _serviceStatus.dwCurrentState = ServiceState.SERVICE_STOPPED;
            SetServiceStatus(this.ServiceHandle, ref _serviceStatus);
        }
    }

    public enum ServiceState
    {
        SERVICE_STOPPED = 0x00000001,
        SERVICE_START_PENDING = 0x00000002,
        SERVICE_STOP_PENDING = 0x00000003,
        SERVICE_RUNNING = 0x00000004,
        SERVICE_CONTINUE_PENDING = 0x00000005,
        SERVICE_PAUSE_PENDING = 0x00000006,
        SERVICE_PAUSED = 0x00000007,
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ServiceStatus
    {
        public long dwServiceType;
        public ServiceState dwCurrentState;
        public long dwControlsAccepted;
        public long dwWin32ExitCode;
        public long dwServiceSpecificExitCode;
        public long dwCheckPoint;
        public long dwWaitHint;
    };
}
