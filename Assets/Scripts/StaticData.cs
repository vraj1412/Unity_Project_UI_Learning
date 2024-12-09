using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData 
{
    public static float Sound
    {
        get
        {
            return PlayerPrefs.GetFloat("Sound", 0.0f);
        }
        set
        {
            PlayerPrefs.SetFloat("Sound", value);
            PlayerPrefs.Save();
        }
    }
    public static float Music
    {
        get
        {
            return PlayerPrefs.GetFloat("Music", 0.0f);

        }
        set
        {
            PlayerPrefs.SetFloat("Music", value);
            PlayerPrefs.Save();
        }
    }
}
