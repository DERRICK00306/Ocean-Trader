using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{


    public GameObject closeWarning;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
       
        Instantiate(closeWarning);
    }

    public void QuitGameImmediate()
    {
        Application.Quit();
    }
}
