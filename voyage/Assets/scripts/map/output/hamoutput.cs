using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port8.firstarrivalham == 0 && sail.arrival == 1 && sail.portarrival == 8)
        {
            GameObject.Find("Ham").SetActive(true);
        }
        else
        {
            GameObject.Find("Ham").SetActive(false);
        }
    }
}
