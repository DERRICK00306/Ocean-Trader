using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remember : MonoBehaviour
{
    public Vector3 position;
    // Start is called before the first frame update

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
