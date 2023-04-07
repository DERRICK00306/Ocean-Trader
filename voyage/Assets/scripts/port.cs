using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class port : MonoBehaviour
{
    public float sleep_time = 4;
    public GameObject cloud1, cloud2;
    public AudioSource audio_source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator OnTriggerEnter2D(Collider2D obj)
    {
        string name = obj.gameObject.name;
        
        Instantiate(cloud1, new Vector2(-18,-6),Quaternion.identity);
        Instantiate(cloud2, new Vector2(18,8),Quaternion.identity);
        Instantiate(audio_source);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Japan");

    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
