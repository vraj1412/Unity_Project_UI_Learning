using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreen : MonoBehaviour
{
    public void SessionPass()
    {
        DebugDemo.Log("Session Pass Opened..");
    }
    public void heroes()
    {
        DebugDemo.Log("Heroes Opened..");
    }
    public void eqipment()
    {
        DebugDemo.Log("Eqipment Opened..");
    }
    public void artifact()
    {
        DebugDemo.Log("Artifact Opened..");
    }
    public void upgrade()
    {
        DebugDemo.Log("Upgrade Opened..");
    }
    public void shop()
    {
        DebugDemo.Log("Shop Opened..");
    }
    public void world()
    {
        DebugDemo.Log("World Opened..");
    }
    public void Start()
    {
        DebugDemo.Log("Start Opened..");
    }
    public void mission()
    {
        DebugDemo.Log("Mission Opened..");
    }
    public void club()
    {
        DebugDemo.Log("Club Opened..");
    }
    public void ranking()
    {
        DebugDemo.Log("Ranking Opened..");
    }
    public void setting()
    {
        DebugDemo.Log("Setting Opened..");
    }

    public void CheckMerge ()
    {
        DebugDemo.Log("Merge is done");
    }
}


    public static class DebugDemo
{
    public static void Log(string Str)
    {
        Debug.Log(Str);
    }

    public static void LogWarning(string Str)
    {
        Debug.LogWarning(Str);
    }public static void LogError(string Str)
    {
        Debug.LogError(Str);
    }

}
