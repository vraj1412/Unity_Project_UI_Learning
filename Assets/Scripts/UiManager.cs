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

    //SoundAndMusic SoundMusic;

    public void Start()
    {
        SoundSlider.value = StaticData.Sound;
        MusicSlider.value = StaticData.Music;
        SetSoundAndMusic();

        //  SoundMusic = SoundAndMusic.instance;
        SoundAndMusic.instance.PlayMusic(BgMusic_Clip);
    }


   /* public void ButtonControl(string button)
    {
        SoundAndMusic.instance.PlaySound(Button_Clip);

        switch (button)
        {
           
            case "Sound":
                Sound_Slidar();
                break;
            case "Music":
                Music_Slidar();
                break;
            case "Sound_Mute":
                Sound_Icon();
                break;
            case "Music_Mute":
                Music_Icon();
                break;
        }
    }*/
    public void Sound_Slidar()
    {
        StaticData.Sound = SoundSlider.value;
        //soundandmusic.SoundAudioSource.volume = SoundSlider.value;
        SoundAndMusic.instance.SetSound_Volume(SoundSlider.value);
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
        SoundAndMusic.instance.SetMusic_Volume(MusicSlider.value);
        // soundandmusic.MusicAudioSource.volume = MusicSlider.value;
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
            SoundAndMusic.instance.SoundMute(true);
        }
        else
        {
            StaticData.MuteSound = 0;
            SoundImage.sprite = SoundSprite;
            SoundAndMusic.instance.SoundMute(false);
        }
    }

    public void MusicMute(bool mute)
    {
        if (mute)
        {
            StaticData.MuteMusic = 1;
            MusicImage.sprite = MuteMusicSprite;
            SoundAndMusic.instance.MuiscMute(true);
        }
        else
        {
            StaticData.MuteMusic = 0;
            MusicImage.sprite = MusicSprite;
            SoundAndMusic.instance.MuiscMute(false);
        }
    }

    public void SetSoundAndMusic()
    {
        if (StaticData.MuteSound == 0)
        {
            SoundMute(false);
        }
        else
        {
            SoundMute(true);
        }

        if (StaticData.MuteMusic == 0)
        {
            MusicMute(false);
        }
        else
        {
            MusicMute(true);
        }
    }
}
