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

        //switch (button)
        //{
        //    case "Sound_Mute":
        //        Mutesound();
        //        break;
        //    case "Music_Mute":
        //        Mutemusic();
        //        break;
        //    case "Unmute_sound":
        //        Unmutesound(); 
        //        break;
        //    case "Unmute_music":
        //        Unmutemusic();
        //        break;
        //}
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
    public void SoundMute(bool mute)
    {

        SoundAudioSource.mute = mute;
    }
    public void SetSound_Volume(float Volume)
    {
        SoundAudioSource.volume = Volume;
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
    public void MuiscMute(bool mute)
    {
        MusicAudioSource.mute = mute;
    }
    public void SetMusic_Volume(float Volume)
    {
        MusicAudioSource.volume = Volume;
    }
    #endregion

    public void PauseSoundAndMusic(bool IsPuse)
    {
        if (IsPuse)
        {
            SoundAudioSource.Pause();
            MusicAudioSource.Pause();
        }
        else
        {
            SoundAudioSource.UnPause();
            MusicAudioSource.UnPause();
        }
    }


    public void Sound_Icon()
    {
        if (StaticData.MuteSound == 0)
        {
            SoundMute(true);
        }
        else
        {
            SoundMute(false);
        }

    }
    public void Music_Icon()
    {
        if (StaticData.MuteMusic == 0)
        {
            MusicMute(true);
        }
        else
        {
            MusicMute(false);
        }
    }

   
}
