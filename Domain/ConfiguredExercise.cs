namespace Domain
{
    public class ConfiguredExercise : DomainBase
    {
        public int Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public Exercise Exercise { get; set; }
    }
}