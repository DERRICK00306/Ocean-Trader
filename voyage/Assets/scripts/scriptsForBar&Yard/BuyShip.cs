using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BuyShip : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {

        if (Global.Money >= button.GetComponent<ShipInfoTrigger>().ship.price && button.GetComponent<ShipInfoTrigger>().ship.unlock == false)
        {

            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect3();

            Global.Money -= button.GetComponent<ShipInfoTrigger>().ship.price;

            Global.MaxLoad = Global.ShipSelect[Global.ships[button.GetComponent<ShipInfoTrigger>().ship.itemID]];



            button.GetComponent<ShipInfoTrigger>().ship.unlock = true;
            FindObjectOfType<ShipInfoManager>().StartShipDescription(button.GetComponent<ShipInfoTrigger>().ship);
        }
        else
        {
            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
            // method if item is sold out.
        }

    }
}
