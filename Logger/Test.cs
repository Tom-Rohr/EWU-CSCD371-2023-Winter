using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Logger
{

    public class Test
    {
        public static void main(string[] args)
        {
            string currentPath = "/";

            LogFactory factory = new LogFactory();
            factory.ConfigureFileLogger(currentPath);
            BaseLogger logger = factory.CreateLogger("FileLogger");

            string[] consoleMessage = { "one", " two", " three" };
            string message = " ";
            logger.Error(message, consoleMessage);

        }
    }

}