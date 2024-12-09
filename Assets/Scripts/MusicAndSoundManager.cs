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

}
