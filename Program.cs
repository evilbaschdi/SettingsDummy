using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SettingsDummy
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyValueConfiguration = KeyValue.AppSetting;
            Console.WriteLine(keyValueConfiguration["Black"]);
            Console.WriteLine();
            Console.WriteLine(keyValueConfiguration["Dei"]);

            Console.WriteLine("---");
            Console.WriteLine();

            var keyValueListAlterBridge = KeyValueList.AppSetting.GetSection("AlterBridge").Get<List<string>>();
            var keyValueListCreed = KeyValueList.AppSetting.GetSection("Creed").Get<List<string>>();

            keyValueListAlterBridge.ForEach(Console.WriteLine);
            Console.WriteLine();
            keyValueListCreed.ForEach(Console.WriteLine);

            Console.WriteLine("---");
            Console.ReadLine();
        }
    }
}