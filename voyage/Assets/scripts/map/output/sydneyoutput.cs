using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sydneyoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (port3.firstarrivalsydney == 0 && sail.arrival == 1 && sail.portarrival == 3)
        {
            GameObject.Find("sydney").SetActive(true);
        }
        else
        {
            GameObject.Find("sydney").SetActive(false);
        }
    }
}
