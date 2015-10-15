namespace Domain
{
    public class User : DomainBase
    {
        public string EmailAddress { get; set; }
        //TODO: should be encrypted
        public string Password { get; set; }
        public ConfigSetting ConfigSetting { get; set; }

    }
}