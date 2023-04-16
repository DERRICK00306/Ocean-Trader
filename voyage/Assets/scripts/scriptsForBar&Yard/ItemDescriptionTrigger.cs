using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemDescriptionTrigger : MonoBehaviour
{
    
    public Item item;
    public GameObject itemButton;
    public GameObject ShopManager;

    private void Start()
    {
        item.name = itemButton.GetComponent<ButtonInfo>().itemNames;
        item.itemID = itemButton.GetComponent<ButtonInfo>().itemID;

    }

    private void Update()
    {
        item.price = ShopManager.GetComponent<ShopManagerScript>().shopItems[2, item.itemID];
    }




    public void TriggerDescription()
    {
        FindObjectOfType<ItemManager>().StartDescription(item);
    }
}
