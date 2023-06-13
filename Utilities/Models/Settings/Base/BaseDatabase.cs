namespace Utilities.Models.Settings.Base
{
    public class BaseDatabase
    {
        public bool CreateDataBase { get; set; }
        public Dictionary<string, Dictionary<string, string>> ConnectionString { get; set; }

        public BaseDatabase()
        {
            CreateDataBase = false;
            ConnectionString = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}
