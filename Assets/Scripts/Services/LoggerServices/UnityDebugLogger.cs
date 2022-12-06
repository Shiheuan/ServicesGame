public class UnityDebugLogger : DebugLogger
{
    private const string UNDEFINED = "UNDEFINED";
    private string prefix_;

    public UnityDebugLogger(string prefix = null)
    {
        if (string.IsNullOrEmpty(prefix))
        {
            prefix = UNDEFINED;
        }
        prefix_ = prefix;
    }
    
    public override void Log(object message)
    {
        UnityEngine.Debug.Log($"[{prefix_}]{message}");
    }

    public override void LogWarning(object message)
    {
        UnityEngine.Debug.LogWarning($"[{prefix_}]{message}");
    }

    public override void LogError(object message)
    {
        UnityEngine.Debug.LogError($"[{prefix_}]{message}");
    }
}
