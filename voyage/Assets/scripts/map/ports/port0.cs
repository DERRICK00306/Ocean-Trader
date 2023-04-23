using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class port0 : MonoBehaviour
{
    public static int firstarrivalhong = 0;
    public GameObject cloud1, cloud2;
    public AudioSource audio_source;
    bool initiate = true;
    float timer = 99999f;
    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frames
    void Update()
    {
        timer -= Time.deltaTime;

        if (port0.firstarrivalhong == 1 && sail.arrival == 1 && sail.portarrival == 0)
        {
            if (initiate == true)
            {
                Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
                Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
                Instantiate(audio_source);
                initiate = false;
                timer = 2f;
            }
            if (timer < 0)
            {
                remember.position = GameObject.Find("ship1").transform.position;


                SceneManager.LoadScene("Hong_Kong");
                port0.firstarrivalhong = 0;

            }

        }





    }


}



