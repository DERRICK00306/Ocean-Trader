using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CheckShip : MonoBehaviour
{
    public Image[] ship;
    
    public Sprite[] icon;

    public TextMeshProUGUI[] text;

    public Button[] button;


    public void InitialiseStore()
    {
        int index = 0;
        foreach (bool status in Global.ShipStatus.Values)
        {
            if (status == true)
            {
                button[index].GetComponent<ShipInfoTrigger>().ship.unlock = true;
            }
            index++;
        }
    }

        public void InitialiseBag()
    {
        int index = 0;
        foreach (bool status in Global.ShipStatus.Values)
        {
            if (status == true)
            {
                ship[index].sprite = icon[index];
                text[index].text = "Unlocked";
            }
            index++;
        }
    }
}
