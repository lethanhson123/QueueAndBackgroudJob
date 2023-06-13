namespace Utilities.Models.Settings.Base
{
    public class BaseConfig
    {
        public BaseDatabase Dbs { get; set; }
        public BaseEmailSetting Email { get; set; }

        public BaseConfig() {
            Dbs = new BaseDatabase();
            Email = new BaseEmailSetting();
        }
    }
}
