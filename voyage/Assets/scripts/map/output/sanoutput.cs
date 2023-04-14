using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port12.firstarrivalsan == 0 && sail.arrival == 1 && sail.portarrival == 12)
        {
            GameObject.Find("san").SetActive(true);
        }
        else
        {
            GameObject.Find("san").SetActive(false);
        }
    }
}
