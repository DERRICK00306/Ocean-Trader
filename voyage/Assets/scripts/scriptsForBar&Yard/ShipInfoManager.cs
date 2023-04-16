using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
// using static UnityEditor.Progress;

public class ShipInfoManager : MonoBehaviour
{
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI loadText;
    public TextMeshProUGUI statusText;
    public TextMeshProUGUI shipInfoText;

    public void StartShipDescription(Ship ship)
    {
        priceText.text = "Price: " + ship.price.ToString() + "$";
        nameText.text = "Name: " + ship.name;
        speedText.text = "Speed: " + ship.speed.ToString();
        loadText.text = "Max Load: " + ship.load.ToString();
        if (ship.unlock) statusText.text = "Status: Unlocked";
        else statusText.text = "Status: Locked";
        shipInfoText.text = ship.description;
    }

}
