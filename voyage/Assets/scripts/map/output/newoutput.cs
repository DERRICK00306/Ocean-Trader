using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port10.firstarrivalnew == 0 && sail.arrival == 1 && sail.portarrival == 10)
        {
            GameObject.Find("new").SetActive(true);
        }
        else
        {
            GameObject.Find("new").SetActive(false);
        }
    }
}
