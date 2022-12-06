using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    ICustomAudio audioMgr;
    DebugLogger logger;
    void Awake()
    {
        // prepare locator TODO: somewhere else provide all services
        var audio = new ConsoleAudioManager();
        var loggedAudio = new LoggedAudioManager(audio);
        DebugLoggerLocator.Provide(new UnityDebugLogger(""));
        CustomAudioLocator.Provide(loggedAudio);
        // end prepare
        audioMgr = CustomAudioLocator.GetCustomAudio();
        logger = DebugLoggerLocator.GetDebugLogger();
    }

    // Start is called before the first frame update
    void Start()
    {
        var s = "TEST";
        logger.Log($"Test Conditional Attribute in abstract class. Log {s}"); // worked
        logger.LogError($"Test Conditional Attribute in abstract class. ErrorLog {s}"); // worked
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            audioMgr.PlaySound(0);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            audioMgr.StopAllSound();
        }
    }
}
