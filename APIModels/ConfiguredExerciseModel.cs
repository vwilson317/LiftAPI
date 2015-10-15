namespace APIModels
{
    public class ConfiguredExerciseModel : ModelBase
    {
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public ExerciseModel Exercise { get; set; }
    }
}