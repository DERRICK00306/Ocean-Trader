using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alexoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port5.firstarrivalalex == 0 && sail.arrival == 1 && sail.portarrival == 5)
        {
            GameObject.Find("alex").SetActive(true);
        }
        else
        {
            GameObject.Find("alex").SetActive(false);
        }
    }
}
