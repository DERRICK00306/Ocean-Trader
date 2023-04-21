using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class EquipShip : MonoBehaviour
{
    public Button button;

    public void Equip()
    {
        if (Global.ShipStatus[Global.ships[button.GetComponent<ShipInfoTrigger>().ship.itemID]] == true)
        {
            
            foreach (string ship in Global.ships)
            {
                Global.ShipSelect[ship] = false;
            }

            Global.ShipSelect[Global.ships[button.GetComponent<ShipInfoTrigger>().ship.itemID]] = true;
            
            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect5();
            Global.Cost = button.GetComponent<ShipInfoTrigger>().ship.cost;
            Global.MaxLoad = Global.ShipLoad[Global.ships[button.GetComponent<ShipInfoTrigger>().ship.itemID]];
            Global.GameAttribute["Speed"] = Global.ShipSpeed[Global.ships[button.GetComponent<ShipInfoTrigger>().ship.itemID]];
            Global.GameAttribute["Strength"] = Global.ShipCost[Global.ships[button.GetComponent<ShipInfoTrigger>().ship.itemID]];


        }
        else FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
    }
}
