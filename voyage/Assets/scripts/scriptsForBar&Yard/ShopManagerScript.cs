using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[4, 10];
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
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;

        // Prices
        shopItems[2, 1] = 1000;
        shopItems[2, 2] = 200;
        shopItems[2, 3] = 300;
        shopItems[2, 4] = 400;
        shopItems[2, 5] = 0;
        shopItems[2, 6] = 0;
        shopItems[2, 7] = 0;
        shopItems[2, 8] = 0;
        shopItems[2, 9] = 0;

        // Quantities
        shopItems[3, 1] = 20;
        shopItems[3, 2] = 2;
        shopItems[3, 3] = 3;
        shopItems[3, 4] = 4;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;
        shopItems[3, 8] = 0;
        shopItems[3, 9] = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (Global.Money >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemID] && shopItems[3, ButtonRef.GetComponent<ButtonInfo>().itemID] > 0)
        {

            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect3();

            Global.Money -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemID];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().itemID]--;
        }
        else
        {
            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
            // method if item is sold out.
        }

        ButtonRef.GetComponent<ButtonInfo>().quantityText.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().itemID].ToString();
    }
}