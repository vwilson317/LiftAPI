namespace Domain
{
    public class ConfiguredExercise : Entity
    {
        public virtual int Weight { get; set; }
        public virtual int Reps { get; set; }
        public virtual int Sets { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}