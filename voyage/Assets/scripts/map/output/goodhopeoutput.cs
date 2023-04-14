using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodhopeoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port4.firstarrivalgood == 0 && sail.arrival == 1 && sail.portarrival == 4)
        {
            GameObject.Find("good").SetActive(true);
        }
        else
        {
            GameObject.Find("good").SetActive(false);
        }
    }
}
