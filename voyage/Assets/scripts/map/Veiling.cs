using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veiling : MonoBehaviour
{
    public GameObject cloud1, cloud2;
    public AudioSource audio_source;
    // Start is called before the first frame update
    public void veiling()
    {
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
    }
}
