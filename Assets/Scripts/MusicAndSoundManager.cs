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


    public void Awake()
    {
        volumeSlider.value = StaticData.Sound;
       
    }
    void Start()
    {
        /* if (!PlayerPrefs.HasKey("soundVolume") )
         {
             PlayerPrefs.SetFloat ("soundVolume", 1);
         }
         volumeLoad();

         if(!PlayerPrefs.HasKey("musciVolume"))
         {
             PlayerPrefs.SetFloat("musicVolume", 1);
         }
         musicLoad();*/
        Load_Music();
        PlayMusic();
        
    }
  //  #region sound


   /* public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        volumeSave();
    }

    private void volumeSave()
    {
        PlayerPrefs.SetFloat("soundVolume", volumeSlider.value);
        
    }
    private void volumeLoad() {
       
        volumeSlider.value = PlayerPrefs.GetFloat("soundVolume", volumeSlider.value);
    }

    #endregion







    #region music
    public void ChangeMusic()
    {
        AudioListener.volume = musicSlider.value;
        musicSave();
    }
    private void musicSave()
    {
        PlayerPrefs.SetFloat("musciVolume", musicSlider.value);
         
    }
    private void musicLoad()
    {

        musicSlider.value = PlayerPrefs.GetFloat("musciVolume", musicSlider.value);
    }
    #endregion*/


    public void Sound()
    {

        StaticData.Sound = volumeSlider.value;

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
