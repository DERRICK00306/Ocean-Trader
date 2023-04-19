using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPreScene : MonoBehaviour
{
    public string previous;

    // Start is called before the first frame update
    void Start()
    {
        Global.PreviousScene = previous;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
