using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{

    [Header("Slider")]
    public Slider SoundSlider;
    public Slider MusicSlider;
    [Space]
    [Header("SoundAndMusic MuteParent")]
    public Image SoundImage;
    public Image MusicImage;
    [Space]
    [Header("SoundAndMusic ImageSprite")]
    public Sprite SoundSprite;
    public Sprite MusicSprite;
    public Sprite MuteSoundSprite;
    public Sprite MuteMusicSprite;

    [Space]
    [Header("SoundAndMusic Clip")]
    public AudioClip Button_Clip;
    public AudioClip BgMusic_Clip;

    private float temp ;  


    public SoundAndMusic Ref_SoundAndMusicManager;



    public void Start()
    {
        Ref_SoundAndMusicManager = SoundAndMusic.instance;

        SoundSlider.value = StaticData.Sound;
        MusicSlider.value = StaticData.Music;

        SetSoundAndMusicValue();
        Ref_SoundAndMusicManager.PlayMusic(BgMusic_Clip);
    }

    public void Sound_Slidar()
    {
        StaticData.Sound = SoundSlider.value;

        Ref_SoundAndMusicManager.SetSound_Volume(SoundSlider.value);
        if (StaticData.Sound == 0)

        {

            SoundMute(true);
        }
        else
        {
            SoundMute(false);
        }
    }

    public void Music_Slidar()
    {
        StaticData.Music = MusicSlider.value;
        Ref_SoundAndMusicManager.SetMusic_Volume(MusicSlider.value);
        
        if (StaticData.Music == 0)
        {

            MusicMute(true);
        }
        else
        {
            MusicMute(false);
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

    public void SoundMute(bool mute)
    {

        if (mute)
        {
            StaticData.MuteSound = 1;
            SoundImage.sprite = MuteSoundSprite;
            Ref_SoundAndMusicManager.SoundMute(true);
            SoundSlider.value = 0;
        }
        else
        {
            StaticData.MuteSound = 0;
            SoundImage.sprite = SoundSprite;
            Ref_SoundAndMusicManager.SoundMute(false);
        }
    }

    public void MusicMute(bool mute)
    {
       
        if (mute)
        {
            temp = MusicSlider.value;
            StaticData.MuteMusic = 1;
            MusicImage.sprite = MuteMusicSprite;
            Ref_SoundAndMusicManager.MuiscMute(true);
            MusicSlider.value = 0;
            
        }
        else
        {
            MusicSlider.value = temp;
            //StaticData.MuteMusic = 0;
            MusicImage.sprite = MusicSprite;
            Ref_SoundAndMusicManager.MuiscMute(false);
            
        }
    }

    public void SetSoundAndMusicValue()
    {

        SoundMute(StaticData.MuteSound != 0);
        MusicMute(StaticData.MuteMusic != 0);


    }
}