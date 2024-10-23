using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPrefs : MonoBehaviour
{
    public GameObject Prefs;
    public Transform Parent;
    public List<Sprite> Sprites = new List<Sprite>();

    public void RandomeObstacl()
    {

        GameObject gameObject = Instantiate(Prefs, Parent);
        gameObject.transform.position = new Vector3(Random.Range(-5 ,5), Random.Range(-5, 5), 0);
        Prefs.GetComponent<SpriteRenderer>().sprite= Sprites[Random.Range(0, 5)];
        gameObject.SetActive(true);
    }
}
