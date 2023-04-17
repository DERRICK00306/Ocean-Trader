using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialisation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Global.Money = 5000;
        Global.Speed = 0;
        Global.Luck = 0;
        Global.Carry = 0;
        Global.Discount = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
