using System.IO;
using Microsoft.Extensions.Configuration;

namespace SettingsDummy
{
    /// <summary>
    /// </summary>
    public static class KeyValueList
    {
        static KeyValueList()
        {
            AppSetting = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory())
                         .AddJsonFile("KeyValueList.json")
                         .Build();
        }

        /// <summary>
        /// </summary>
        public static IConfiguration AppSetting { get; }
    }
}