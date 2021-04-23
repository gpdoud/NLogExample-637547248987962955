using Microsoft.Extensions.Configuration;
using NLog;
using System;

namespace NLogExample {

    class Program {
    
        static void Main(string[] args) {

            var logger = LogManager.GetCurrentClassLogger();
            var config = new ConfigurationBuilder()
                            // from Microsoft.Extensions.Configuration.Json package
                            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .Build();
            logger.Info("This is an info message");
            logger.Warn("This is a warning message");
            logger.Error("This is an error message");
            LogManager.Shutdown();
            Console.Write("press any key ... ");
            Console.ReadKey();
        }
    }
}
