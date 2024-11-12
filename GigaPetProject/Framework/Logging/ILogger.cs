namespace GigaPetProject.Framework.Logging
{
    public interface ILogger
    {
        string Log(string message, LogInfo serverity);
    }

    public enum LogInfo
    {
        Debug = -1,
        Info = 0,
        Warn = 1,
        Error = 2,
        Fatal = 3,
    }
}
