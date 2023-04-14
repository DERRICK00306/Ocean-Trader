using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{
    public string itemNames;
    public int itemID;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;

    public GameObject ShopManager;


    // Update is called once per frame
    void Update()
    {
        priceText.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[2, itemID].ToString() + "$";
        quantityText.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, itemID].ToString();
    }
}
