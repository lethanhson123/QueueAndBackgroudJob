namespace Utilities.Models.Settings.Base
{
    public sealed class BaseEmailSetting
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool SslRequired { get; set; }
        public bool TlsRequired { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
