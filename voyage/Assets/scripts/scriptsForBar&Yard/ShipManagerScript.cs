using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipManagerScript : MonoBehaviour
{

    public int[,] shipItems = new int[4, 10];
    //public string[] itemNames = new string[10];

    // Start is called before the first frame update
    void Start()
    {
        /*
        // Names
        itemNames[1] = "";
        itemNames[2] = "";
        itemNames[3] = "";
        itemNames[4] = "";
        itemNames[5] = "";
        itemNames[6] = "";
        itemNames[7] = "";
        itemNames[8] = "";
        itemNames[9] = "";
        */

        // IDs
        shipItems[1, 1] = 1;
        shipItems[1, 2] = 2;
        shipItems[1, 3] = 3;
        shipItems[1, 4] = 4;
        shipItems[1, 5] = 5;
        shipItems[1, 6] = 6;
        shipItems[1, 7] = 7;
        shipItems[1, 8] = 8;
        shipItems[1, 9] = 9;

        // Prices
        shipItems[2, 1] = 1000;
        shipItems[2, 2] = 200;
        shipItems[2, 3] = 300;
        shipItems[2, 4] = 400;
        shipItems[2, 5] = 0;
        shipItems[2, 6] = 0;
        shipItems[2, 7] = 0;
        shipItems[2, 8] = 0;
        shipItems[2, 9] = 0;

        // Quantities
        shipItems[3, 1] = 20;
        shipItems[3, 2] = 2;
        shipItems[3, 3] = 3;
        shipItems[3, 4] = 4;
        shipItems[3, 5] = 0;
        shipItems[3, 6] = 0;
        shipItems[3, 7] = 0;
        shipItems[3, 8] = 0;
        shipItems[3, 9] = 0;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (Global.Money >= shipItems[2, ButtonRef.GetComponent<ButtonInfo>().itemID] && shipItems[3, ButtonRef.GetComponent<ButtonInfo>().itemID] > 0)
        {

            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect3();

            Global.Money -= shipItems[2, ButtonRef.GetComponent<ButtonInfo>().itemID];
            shipItems[3, ButtonRef.GetComponent<ButtonInfo>().itemID]--;
        }
        else
        {
            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
            // method if item is sold out.
        }

        ButtonRef.GetComponent<ButtonInfo>().quantityText.text = shipItems[3, ButtonRef.GetComponent<ButtonInfo>().itemID].ToString();
    }
}
