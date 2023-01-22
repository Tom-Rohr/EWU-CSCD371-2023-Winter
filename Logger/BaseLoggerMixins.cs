using System;

namespace Logger
{
    public static class BaseLoggerMixins //todo
    {
        public static void Error(this BaseLogger logger, string message, string[] args)
        {
            if (logger is null)
            {
                throw new ArgumentNullException();
            }
            string.Format(message, args);
            logger.Log(LogLevel.Error, message);
        }
        public static void Warning(this BaseLogger logger, string message, string[] args)
        {
            if (logger is null)
            {
                throw new ArgumentNullException();
            }
            string.Format(message, args);
            logger.Log(LogLevel.Warning, message);
        }
        public static void Information(this BaseLogger logger, string message, string[] args)
        {
            if (logger is null)
            {
                throw new ArgumentNullException();
            }
            string.Format(message, args);
            logger.Log(LogLevel.Information, message);
        }
        public static void Debug( this BaseLogger logger, string message, string[] args)
        {
            if (logger is null)
            {
                throw new ArgumentNullException();
            }
            string.Format(message, args);
            logger.Log(LogLevel.Debug, message);
        }

    }
}
