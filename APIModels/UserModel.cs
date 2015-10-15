namespace APIModels
{
    public class UserModel : ModelBase
    {
        public string EmailAddress { get; set; }
        //TODO: should be encrypted
        public string Password { get; set; }
        public ConfigSettingModel ConfigSetting { get; set; }

    }
}