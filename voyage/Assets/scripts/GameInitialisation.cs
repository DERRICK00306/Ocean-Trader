using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitialisation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sail.change = 0;
        Global.Count = 0;
        Global.Money = 2500;
        Global.Carry = 0;
        Global.MaxLoad = 0;
        Global.Cost = 0;
        
        
        foreach (string ship in Global.ships)
        {
            Global.ShipStatus[ship] = false;
        }

        foreach (string item in Global.bag)
        {
            Global.Package[item] = 0;
        }

        foreach (string attribute in Global.attributes)
        {
            Global.GameAttribute[attribute] = 0;
        }

        foreach (string town in Global.city)
        {
            Global.ChinaTown[town] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
