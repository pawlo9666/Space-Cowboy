
using UnityEngine;

public class SecondAudioSettings : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioSource[] soundEffect;
    private static readonly string Sound = "Sound";
    private static readonly string Effect = "Effect";
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
