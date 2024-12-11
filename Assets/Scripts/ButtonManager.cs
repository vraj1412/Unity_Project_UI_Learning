using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [Header("Ref_")]
    public UiManager Ref_UiManager;
    [HideInInspector]
    public SoundAndMusic SoundAndMusic;

    public void Start()
    {
        SoundAndMusic = SoundAndMusic.instance;
    }
    public void ButtonControl(string button)
    {
        SoundAndMusic.PlaySound(Ref_UiManager.Button_Clip);

        switch (button)
        {

            case "Sound":
              Ref_UiManager.Sound_Slidar();
                break;
            case "Music":
                Ref_UiManager.Music_Slidar();
                break;
            case "Sound_Mute":
                Ref_UiManager.Sound_Icon();
                break;
            case "Music_Mute":
                Ref_UiManager.Music_Icon();
                break;
        }
    }
}
