using System.Diagnostics;

public abstract class DebugLogger
{
    // add colored prefix
    // save to single log file
    [Conditional("ENABLE_LOG")]
    public abstract void Log(object message);
    [Conditional("ENABLE_LOG")]
    public abstract void LogWarning(object message);
    //[Conditional("ENABLE_LOG")]
    public abstract void LogError(object message);
}
