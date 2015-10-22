namespace Domain
{
    public class AccountInfo : Entity
    {
        public virtual string EmailAddress { get; set; }
        //TODO: should be encrypted
        public virtual string Password { get; set; }

    }
}