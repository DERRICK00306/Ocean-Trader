using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using static UnityEditor.Progress;

public class ItemManager : MonoBehaviour
{
    
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI priceText;
    //public TextMeshProUGUI stockText;
    public TextMeshProUGUI informationText;

    public void StartDescription(Item item)
    {
        nameText.text = item.name;
        priceText.text = item.price.ToString() + "$";
        // stockText.text = item.stock.ToString();
        informationText.text = item.description;
    }

}
