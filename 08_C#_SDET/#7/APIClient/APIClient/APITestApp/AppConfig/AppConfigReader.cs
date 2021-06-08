

//This is going to allow us to access the app.config file via the key

using System.Configuration;

namespace APITestApp
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
