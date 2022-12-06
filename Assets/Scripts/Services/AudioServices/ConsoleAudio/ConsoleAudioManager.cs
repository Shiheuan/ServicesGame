using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleAudioManager : ICustomAudio
{

    public void PlaySound(int soundID)
    {
        Debug.Log($"Console Audio Manager Played Audio ID: {soundID}.");
    }

    public void StopSound(int soundID)
    {
        Debug.Log($"Console Audio Manager Stoped Audio ID: {soundID}.");
    }

    public void StopAllSound()
    {
        Debug.Log($"Console Audio Manager Stoped ALL Audio.");
    }

}
