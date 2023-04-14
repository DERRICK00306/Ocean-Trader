using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShipInfoTrigger : MonoBehaviour
{

    public Ship ship;
    public GameObject shipButton;
    //public GameObject ShopManager;

    private void Start()
    {
        //ship.name = shipButton.GetComponent<ButtonInfo>().itemNames;
        //ship.itemID = shipButton.GetComponent<ButtonInfo>().itemID;

    }

    private void Update()
    {
        //ship.price = ShopManager.GetComponent<ShopManagerScript>().shopItems[2, item.itemID];
    }




    public void TriggerDescription()
    {
        FindObjectOfType<ShipInfoManager>().StartShipDescription(ship);
    }
}
