using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class port : MonoBehaviour
{
    public float sleep_time = 2;
    public GameObject cloud1, cloud2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator OnTriggerEnter2D(Collider2D obj)
    {
        string name = obj.gameObject.name;
        yield return new WaitForSeconds(sleep_time);
        Instantiate(cloud1, new Vector2(-18,-6),Quaternion.identity);
        Instantiate(cloud2, new Vector2(18,8),Quaternion.identity);
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
