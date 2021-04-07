using StackExchange.Redis;
using System;

namespace HomeWork_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string score = "";
            while (score != "exit")
            {
                var options = new ConfigurationOptions();
                options.EndPoints.Add("localhost", 6379);

                var redis = ConnectionMultiplexer.Connect(options);
                var db = redis.GetDatabase(3);

                const string key1 = "appsKey";
                var value1 = Convert.ToInt32(db.StringGet(key1));

                const string key2 = "appsKey";
                var value2 = Convert.ToInt32(db.StringGet(key2));

                Console.WriteLine($"{value1 + value2}");

                score = Console.ReadLine();
            }
        }
    }
}
