using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unveiling : MonoBehaviour
{
    public GameObject cloud3, cloud4;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        float x1 = (float)-3.120013, y1 = (float)-1.040003;
        float x2 = (float)3.120013, y2 = (float)3.040005;
        Instantiate(cloud3, new Vector2(x1,y1), Quaternion.identity);
        Instantiate(cloud4, new Vector2(x2,y2), Quaternion.identity);
        Instantiate(audioSource);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
