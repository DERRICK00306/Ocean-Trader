using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class singaporeoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port1.firstarrivalsingapore == 0 && sail.arrival == 1 && sail.portarrival == 1)
        {
            GameObject.Find("singapore").SetActive(true);
        }
        else
        {
            GameObject.Find("singapore").SetActive(false);
        }
    }
}
