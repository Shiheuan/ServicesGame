using UnityEngine;

public class DebugLoggerLocator
{
    static DebugLogger service_;
    static DefaultDebugLogger defaultDebugLogger;

    public static void initialize()
    {
        // di default?
        defaultDebugLogger = new DefaultDebugLogger();
        service_ = defaultDebugLogger;
    }

    public static DebugLogger GetDebugLogger()
    {
        return service_;
    }

    public static void Provide(DebugLogger service)
    {
        if (service == null)
        {
            service = defaultDebugLogger;
        }

        service_ = service;
    }
    
}
