using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name; // Item Name.
    public int itemID; //Item ID.
    public int price; // Item Price.
    public int quantity; // Item Quantity.
    [TextArea(5, 5)]
    public string description; // Item Description.
}
