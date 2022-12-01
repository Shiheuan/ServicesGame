// Audio locator
public class Locator
{
    // version 0.1
    // private static ICustomAudio service_;
    // public static ICustomAudio GetCustomAudio()
    // {
    //     return service_;
    // }

    // public static void Provide(ICustomAudio service)
    // {
    //     service_ = service;
    // }
    static ICustomAudio service_;
    static DefaultCustomAudio defaultCustomAudio;

    public static void initialize()
    {
        // di default?
        defaultCustomAudio = new DefaultCustomAudio();
        service_ = defaultCustomAudio;
    }

    public static ICustomAudio GetCustomAudio()
    {
        return service_;
    }

    public static void Provide(ICustomAudio service)
    {
        if (service == null)
        {
            service = defaultCustomAudio;
        }

        service_ = service;
    }
}
