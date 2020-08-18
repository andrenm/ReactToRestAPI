using System;

namespace WebApiExample.Persistence
{
    public class DbContextSettings
    {
        /// <summary>
        /// DbConnectingString from appsettings.json
        /// </summary>
        public string WebApiExampleConnectionString { get; set; }
    }
}
