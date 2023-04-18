using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShipInfoTrigger : MonoBehaviour
{

    public Ship ship;
    public GameObject shipButton;

    public void TriggerDescription()
    {
        FindObjectOfType<ShipInfoManager>().StartShipDescription(ship);
    }
}
