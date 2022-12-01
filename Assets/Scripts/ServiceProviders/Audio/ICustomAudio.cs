using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICustomAudio
{
    public void PlaySound(int soundID);
    public void StopSound(int soundID);
    public void StopAllSound();
}
