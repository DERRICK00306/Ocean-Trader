using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNew : MonoBehaviour
{
    public GameObject contd;
    // Start is called before the first frame update
    void Start()
    {
        if (Global.NewGame == false)
        {
            contd.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
