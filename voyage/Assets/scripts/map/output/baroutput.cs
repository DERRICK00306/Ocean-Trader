using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baroutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port9.firstarrivalbar == 0 && sail.arrival == 1 && sail.portarrival == 9)
        {
            GameObject.Find("Bar").SetActive(true);
        }
        else
        {
            GameObject.Find("Bar").SetActive(false);
        }
    }
}
