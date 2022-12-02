using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    ICustomAudio audioMgr;
    void Awake()
    {
        // prepare locator TODO: somewhere else provide all services
        var audio = new ConsoleAudioManager();
        var loggedAudio = new LoggedAudioManager(audio);
        CustomAudioLocator.Provide(loggedAudio);
        // end prepare
        audioMgr = CustomAudioLocator.GetCustomAudio();
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
