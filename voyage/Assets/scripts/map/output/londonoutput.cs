using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class londonoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port7.firstarrivallondon == 0 && sail.arrival == 1 && sail.portarrival == 7)
        {
            GameObject.Find("london").SetActive(true);
        }
        else
        {
            GameObject.Find("london").SetActive(false);
        }
    }
}
