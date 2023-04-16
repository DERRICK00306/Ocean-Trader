using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port11.firstarrivalven == 0 && sail.arrival == 1 && sail.portarrival == 11)
        {
            GameObject.Find("ven").SetActive(true);
        }
        else
        {
            GameObject.Find("ven").SetActive(false);
        }
    }
}
