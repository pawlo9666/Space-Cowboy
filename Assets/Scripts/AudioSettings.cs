
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    public AudioSource audioSrc;
    public  AudioSource[] soundEffect;
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
        for(int i =0; i < soundEffect.Length; i++) { 
            soundEffect[i].volume = PlayerPrefs.GetFloat(Effect);
        }
    }

}
