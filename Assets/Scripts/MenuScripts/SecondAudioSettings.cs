
using UnityEngine;

public class SecondAudioSettings : MonoBehaviour
{
    public AudioSource audioSrc;
    private static readonly string Sound = "Sound";
    private float SoundVolume;
    void Awake()
    {
        GetSettings();
        audioSrc.volume = SoundVolume;
    }

    private void GetSettings()
    {
        //Debug.Log(PlayerPrefs.GetFloat(Sound));
        SoundVolume = PlayerPrefs.GetFloat(Sound);
    }

}
