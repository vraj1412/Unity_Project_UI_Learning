using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderDetect : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision Detected");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
       
       Debug.Log("collision stay");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collistion Exited");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger Detected");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("trigger stay");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("trigger exited");
    }

}
