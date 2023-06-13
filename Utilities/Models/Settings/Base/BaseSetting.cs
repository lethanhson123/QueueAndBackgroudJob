namespace Utilities.Models.Settings.Base
{
    public class BaseSetting
    {
        public BaseApplication Application { get; set; }
        public BaseConfig Config { get; set; }

        public BaseSetting()
        {
            Application = new BaseApplication();
            Config = new BaseConfig();
        }
    }
}
