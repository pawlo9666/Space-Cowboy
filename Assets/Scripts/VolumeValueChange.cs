using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeValueChange : MonoBehaviour
{
    private AudioSource audioSrc;
    private static readonly string Sound = "Sound";
    private static readonly string Effect = "Effect";
    public Slider SoundSlider;
    public Slider EffectSlider;
    private float musicVolume = 0.2f;
    private float soundEffectVolume = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        if (PlayerPrefs.HasKey(Sound))
        {
            musicVolume=PlayerPrefs.GetFloat(Sound);
            soundEffectVolume=PlayerPrefs.GetFloat(Effect);

            SoundSlider.value = PlayerPrefs.GetFloat(Sound);
            EffectSlider.value = PlayerPrefs.GetFloat(Effect);
        }
   
  
    }

    // Update is called once per frame
    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;

    }

    public void SetSoundEffectVolume(float vol)
    {
        soundEffectVolume = vol;
    }

    public void SaveSoundSetting()
    {
        PlayerPrefs.SetFloat(Sound, musicVolume);
        PlayerPrefs.SetFloat(Effect, soundEffectVolume);
        //Debug.Log(PlayerPrefs.GetFloat(Sound));
    }


}
