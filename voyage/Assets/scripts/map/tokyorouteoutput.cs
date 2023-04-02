using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tokyorouteoutput : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (port.firstarrival == 0 && sail.arrival == 1)
        {
            GameObject.Find("tokyo").SetActive(true);
        }
        else
        {
            GameObject.Find("tokyo").SetActive(false);
        }
    }
}
