namespace APIModels
{
    public class ConfiguredExerciseResource : ResourceBase
    {
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public ExerciseResource Exercise { get; set; }
    }
}