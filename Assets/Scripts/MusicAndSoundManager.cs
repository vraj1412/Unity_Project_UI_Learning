using System ;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MusicAndSoundManager : MonoBehaviour
{
    public AudioSource SoundAudioSource;
    public AudioSource MusicAudioSource;
    public Slider volumeSlider;
    public Slider musicSlider;
    public AudioClip BGMusic;
    public AudioClip sound;

    public void ButtonControl(string button)
    {

        switch (button)
        {
            case "Sound_Mute":
                Mutesound();
                break;
            case "Music_Mute":
                Mutemusic();
                break;
            case "Unmute_sound":
                Unmutesound(); 
                break;
            case "Unmute_music":
                Unmutemusic();
                break;
        }
    }
    public void Awake()
    {
        volumeSlider.value = StaticData.Sound;
        musicSlider.value = StaticData.Music;
       
    }
    void Start()
    {
        
        Load_Music();
        PlayMusic();

        Load_sound();
        PlaySound();
        
    }
    #region sound
    public void Sound()
    {

        StaticData.Sound = volumeSlider.value;
        SoundAudioSource.volume = volumeSlider.value;

    }
    public void PlaySound()
    {
        SoundAudioSource.clip = sound;
        SoundAudioSource.Play();
    }
    public void Load_sound()
    {
        volumeSlider.value = StaticData.Sound;
        SoundAudioSource.volume = StaticData.Sound;
    }

    #endregion

    #region music
    public void Music()
    {

        StaticData.Music = musicSlider.value;
        MusicAudioSource.volume = musicSlider.value;

    }

    public void PlayMusic()
    { 
        MusicAudioSource.clip = BGMusic;
        MusicAudioSource.Play();
    }
    public void Load_Music()
    {
        musicSlider.value = StaticData.Music;
        MusicAudioSource.volume = StaticData.Music;
    }

    #endregion

    public void Mutesound()
    {
        Debug.Log("Mute Sound Press");
        SoundAudioSource.Pause();
    }
    public void Mutemusic() { 


        Debug.Log("Mute Music Press");
        MusicAudioSource.Pause();
    }
    public void Unmutesound()
    {
        Debug.Log("Unmute Sound Press");

        SoundAudioSource.UnPause();
    }
    public void Unmutemusic()
    {
        Debug.Log("Unmute Music Press");

        MusicAudioSource.UnPause();
    }
    public void Musicmain()
    {
       
    }
}
