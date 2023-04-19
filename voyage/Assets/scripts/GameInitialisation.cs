using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialisation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Global.Money = 2500;
        Global.Carry = 0;
        Global.MaxLoad = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
