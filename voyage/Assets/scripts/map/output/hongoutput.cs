using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hongoutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (port0.firstarrivalhong == 0 && sail.arrival == 1 && sail.portarrival == 0)
        {
            GameObject.Find("hong").SetActive(true);
        }
        else
        {
            GameObject.Find("hong").SetActive(false);
        }
    }
}
