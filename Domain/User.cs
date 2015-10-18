namespace Domain
{
    public class User : NamedDomainObj
    {
        public PreferenceSetting PreferenceSetting { get; set; }
        public AccountInfo AccountInfo { get; set; }
    }
}