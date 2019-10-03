using System.IO;
using Microsoft.Extensions.Configuration;

namespace SettingsDummy
{
    /// <summary>
    /// </summary>
    public static class KeyValue
    {
        static KeyValue()
        {
            AppSetting = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("KeyValue.json")
                         .Build();
        }


        /// <summary>
        /// </summary>
        public static IConfiguration AppSetting { get; }
    }
}