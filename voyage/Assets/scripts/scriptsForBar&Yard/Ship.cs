using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ship
{
    public string name; // Ship Name.
    public int itemID; //Ship ID.
    public int price; // Ship Price.
    public bool unlock; // Ship Status.
    public int speed; // Ship Speed.
    public int load; // Ship Load.
    public int cost; // Ship Cost.
    [TextArea(5, 5)]
    public string description; // Ship Description.
}
