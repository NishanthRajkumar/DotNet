using NLog;


namespace NLogDemo_DotNet4
{
    internal class NLog
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string input)
        {
            logger.Debug(input);
        }

        public void LogError(string input)
        {
            logger.Error(input);
        }

        public void LogWarn(string input)
        {
            logger.Warn(input);
        }

        public void LogInfo(string input)
        {
            logger.Info(input);
        }

    }
}