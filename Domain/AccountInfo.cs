namespace Domain
{
    public class AccountInfo : DomainBase
    {
        public string EmailAddress { get; set; }
        //TODO: should be encrypted
        public string Password { get; set; }

    }
}