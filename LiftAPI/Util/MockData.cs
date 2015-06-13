using System;
using System.Collections.Generic;
using System.Linq;
using APIModels;

namespace LiftAPI.Util
{
    public class MockData
    {
        private readonly UserMockDataGen _userDataGen = new UserMockDataGen();
        private readonly WorkoutRoutineMockDataGen _workoutDataGen = new WorkoutRoutineMockDataGen();
        private readonly ExerciseMockDataGen _exerciseDataGen = new ExerciseMockDataGen();
        private readonly ExerciseHistoryLogMockDataGen _logDataGen = new ExerciseHistoryLogMockDataGen();
        private readonly MuscleGroupMockDataGen _muscleGroupDataGen = new MuscleGroupMockDataGen();
        private readonly ConfigExerciseMockDataGen _configExerciseMockDataGen = new ConfigExerciseMockDataGen();

        public UserModel User { get; set; }

        //Think about including the type of weights used as part of the exercise
        //Would prevent the user of creating multiple exercises with the weight type
        //append the the exercise name
        public ExerciseModel BenchPress { get; set; }
        public ExerciseModel Squats { get; set; }
        public ExerciseModel Row { get; set; }
        public ExerciseModel PullUps { get; set; }
        public ExerciseModel Situps { get; set; }
        public ExerciseModel DumbBellCurl { get; set; }
        public ExerciseModel Planks { get; set; }
        public ExerciseModel Custom { get; set; }

        public MuscleGroupModel Chest { get; set; }
        public MuscleGroupModel Back { get; set; }
        public MuscleGroupModel Legs { get; set; }
        public MuscleGroupModel Arms { get; set; }
        public MuscleGroupModel Abs { get; set; }

        public WorkoutRoutineModel ChestWorkout { get; set; }
        public WorkoutRoutineModel KillerWorkout { get; set; }

        public ConfiguredExerciseModel ConfiguredBenchPress { get; set; }
        public ConfiguredExerciseModel ConfiguredCustom { get; set; }

        public LogModel SquatsLog1 { get; set; }
        public LogModel PlanksLog2 { get; set; }
        public LogModel PlanksLog1 { get; set; }
        public LogModel BenchPressLog4 { get; set; }
        public LogModel BenchPressLog3 { get; set; }
        public LogModel BenchPressLog1 { get; set; }
        public LogModel BenchPressLog2 { get; set; }

        public List<MuscleGroupModel> MuscleGroups { get; set; }
        public List<ExerciseModel> Exercises { get; set; }
        public List<WorkoutRoutineModel> Workouts { get; set; }
        public List<LogModel> Logs { get; set; }

        private List<T> GetPropertyValues<T>()
        {
            return typeof(MockData).GetProperties()
                        .Where(x => x.PropertyType == typeof(T))
                        .Select(prop => (T)Convert.ChangeType(prop.GetValue(this), typeof(T)))
                        .ToList();
        }

        public MockData()
        {
            User = _userDataGen.Create("Vwilson");

            Chest = _muscleGroupDataGen.Create("Chest");
            Back = _muscleGroupDataGen.Create("Back");
            Legs = _muscleGroupDataGen.Create("Legs");
            Arms = _muscleGroupDataGen.Create("Arms");
            Abs = _muscleGroupDataGen.Create("Abs");

            BenchPress = _exerciseDataGen.Create("Bench Press",Chest);
            Squats = _exerciseDataGen.Create("Squats", Legs);
            Row = _exerciseDataGen.Create("Row", Back);
            PullUps = _exerciseDataGen.Create("Pull Ups", Back);
            Situps = _exerciseDataGen.Create("Sit ups", Abs);
            DumbBellCurl = _exerciseDataGen.Create("DumbBell Curls", Arms);
            Planks = _exerciseDataGen.Create("Planks", Abs);
            Custom = _exerciseDataGen.Create("Vincents Created Exercise", Chest);

            ChestWorkout = _workoutDataGen.Create("Chest Day", User.Id);
            KillerWorkout = _workoutDataGen.Create("Killer Back Workout", User.Id);

            ConfiguredBenchPress = _configExerciseMockDataGen.Create(BenchPress, null, 225, 5, 5);
            ConfiguredCustom = _configExerciseMockDataGen.Create(Custom, null, 20, 10, 10);

            ChestWorkout.ConfiguredExercises.Add(ConfiguredBenchPress);
            ChestWorkout.ConfiguredExercises.Add(ConfiguredCustom);

            BenchPressLog1 = _logDataGen.Create(BenchPress, DateTime.Now.AddDays(-3));
            BenchPressLog2 = _logDataGen.Create(BenchPress, DateTime.Now.AddDays(-2));
            BenchPressLog3 = _logDataGen.Create(BenchPress, DateTime.Now.AddDays(-1));
            BenchPressLog4 = _logDataGen.Create(BenchPress, DateTime.Now);

            PlanksLog1 = _logDataGen.Create(Planks, DateTime.Now.AddDays(-1));
            PlanksLog2 = _logDataGen.Create(Planks, DateTime.Now);

            SquatsLog1 = _logDataGen.Create(Squats, DateTime.Now.AddDays(-2));

            MuscleGroups = GetPropertyValues<MuscleGroupModel>();
            Exercises = GetPropertyValues<ExerciseModel>();
            Workouts = GetPropertyValues<WorkoutRoutineModel>();
            Logs = GetPropertyValues<LogModel>();
        }
    }

    public class UserMockDataGen : MockDataGenBase<UserModel>
    {
        public UserModel Create(string name = "", string password = "p@ssW0rd!", 
            string emailAddress = "fake.email@gmail.com", ConfigSettingModel configSetting = null)
        {
            var model = base.Create(name);
            model.Password = password;
            model.EmailAddress = emailAddress;
            model.ConfigSetting = configSetting;
            return model;
        }
    }

    public class WorkoutRoutineMockDataGen : MockDataGenBase<WorkoutRoutineModel>
    {
        public WorkoutRoutineModel Create(string name = "", int userId = 1, 
            List<ConfiguredExerciseModel> configExercises = null,
            int sortRank = 1, DateTime? completed = null)
        {
            var workoutRoutineModel = base.Create(name);
            workoutRoutineModel.UserId = userId;
            workoutRoutineModel.ConfiguredExercises = new List<ConfiguredExerciseModel>();
            workoutRoutineModel.SortOrderRank = 1;
            workoutRoutineModel.CompletedDate = DateTime.Now;
            return workoutRoutineModel;
        }
    }

    public class ExerciseMockDataGen : MockDataGenBase<ExerciseModel>
    {
        public ExerciseModel Create(string name, MuscleGroupModel muscleGroup)
        {
            var exercise = base.Create(name);
            exercise.MuscleGroupType = muscleGroup;
            return exercise;
        }
    }

    public class ConfigExerciseMockDataGen : MockDataGenBase<ConfiguredExerciseModel>
    {
        public ConfiguredExerciseModel Create(ExerciseModel exercise, DateTime? completed = null, int weight = 5, int sets = 1,
            int reps = 1, int userId = 1)
        {
            var log = base.Create("");
            log.Exercise = exercise;
            log.Weight = weight;
            log.Reps = reps;
            log.Sets = sets;

            return log;
        }
    }

    public class ExerciseHistoryLogMockDataGen : MockDataGenBase<LogModel>
    {
        public LogModel Create(ExerciseModel exercise, DateTime? completed = null, int weight = 5, int sets = 1,
            int reps = 1, int userId = 1)
        {
            var log = base.Create("");
            log.Exercise = exercise;
            log.CompletedDate = completed ?? DateTime.Now;
            log.Weight = weight;
            log.Reps = reps;
            log.Sets = sets;
            log.UserId = userId;
            return log;
        }
    }

    public class MuscleGroupMockDataGen : MockDataGenBase<MuscleGroupModel>
    {
    }

    public class ConfigSettingMockDataGen : MockDataGenBase<ConfigSettingModel>
    {
        public ConfigSettingModel Create(int userId = 1, char weightUnits = 'p', DayOfWeek dayOfWeekStart = DayOfWeek.Monday)
        {
            var configSetting = base.Create("");
            configSetting.UserId = userId;
            configSetting.WeightUnits = weightUnits;
            configSetting.WorkoutStartOfWeek = dayOfWeekStart;
            return configSetting;
        }
    }

    public interface IMockDataGen<T>
    {
        T Create(string name);
    }

    public class MockDataGenBase<T> : IMockDataGen<T> where T : ModelBase, new()
    {
        private int _id = 1;

        public T Create(string name)
        {
            return new T
            {
                Id = _id++,
                Name = name
            };
        }
    }
}