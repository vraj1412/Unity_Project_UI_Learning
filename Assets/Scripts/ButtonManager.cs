using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [Header("Ref_")]
    public UiManager Ref_UiManager;
   
    public SoundAndMusic soundandmusic;

    public void Start()
    {
         soundandmusic = SoundAndMusic.instance;
    }
    public void ButtonControl(string button)
    {
        //Debug.Log("sound and music check"+soundandmusic);
        //Debug.Log("Ui Manager check" +Ref_UiManager);
        //Debug.Log("Ref Of Buttonclip check" +Ref_UiManager.Button_Clip);

        soundandmusic.PlaySound(Ref_UiManager.Button_Clip);

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
