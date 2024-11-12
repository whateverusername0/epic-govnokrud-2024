namespace GigaPetProject.Framework.Logging
{
    /// <summary>
    ///     Provides basic implementations.
    /// </summary>
    public abstract class LoggerBase : ILogger
    {
        public string Log(string message, LogInfo serverity)
        {
            return string.Empty;
        }
    }
}
