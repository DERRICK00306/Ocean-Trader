using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class port : MonoBehaviour
{
    public static int firstarrival = 1;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if (port.firstarrival == 1 && sail.arrival == 1)
        {
            port.firstarrival = 0;
            GameObject.Find("remember").GetComponent<remember>().position = GameObject.Find("ship1").transform.position;
            SceneManager.LoadScene("Japan");

        }
    }

}



