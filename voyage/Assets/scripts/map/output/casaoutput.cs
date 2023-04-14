using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casaoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port6.firstarrivalcasa == 0 && sail.arrival == 1 && sail.portarrival == 6)
        {
            GameObject.Find("casa").SetActive(true);
        }
        else
        {
            GameObject.Find("casa").SetActive(false);
        }
    }
}
