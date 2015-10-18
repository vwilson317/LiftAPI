namespace APIModels
{
    public class UserResource : ResourceBase
    {
        public string EmailAddress { get; set; }
        //TODO: should be encrypted
        public string Password { get; set; }
        public ConfigSettingResource ConfigSetting { get; set; }

    }
}