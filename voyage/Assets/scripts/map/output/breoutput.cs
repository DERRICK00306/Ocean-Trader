using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port13.firstarrivalbre == 0 && sail.arrival == 1 && sail.portarrival == 13)
        {
            GameObject.Find("bre").SetActive(true);
        }
        else
        {
            GameObject.Find("bre").SetActive(false);
        }
    }
}
