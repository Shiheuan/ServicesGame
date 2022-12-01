using System.Diagnostics;
using Debug = UnityEngine.Debug;

class LoggedAudioManager : ICustomAudio
{
    ICustomAudio wrapped_;
    public LoggedAudioManager(ICustomAudio wrapped)
    {
        wrapped_ = wrapped;
    }

    public void PlaySound(int soundID)
    {
        Log("logged: play sound.");
        wrapped_.PlaySound(soundID);
    }

    public void StopSound(int soundID)
    {
        Log("logged: stop sound.");
        wrapped_.StopSound(soundID);
    }

    public void StopAllSound()
    {
        Log("logged: stop all sounds.");
        wrapped_.StopAllSound();
    }

    [Conditional("UNITY_EDITOR")]
    private void Log(string message)
    {
        Debug.Log(message);
    }
}