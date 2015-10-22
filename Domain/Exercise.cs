namespace Domain
{
    public class Exercise : NamedEntity
    {
        public virtual MuscleGroup MuscleGroupType { get; set; }
    }
}