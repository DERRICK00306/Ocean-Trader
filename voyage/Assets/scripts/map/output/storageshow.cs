using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class storageshow : MonoBehaviour
{
    public TextMeshProUGUI text2;
    // Start is called before the first frame update
    void Start()
    {
        text2 = transform.GetComponent<TextMeshProUGUI>();
        if (Global.Package["Corn"] != 0)
        {
            text2.text = text2.text + "Corn: " + Global.Package["Corn"] + "\n";
        }

        if (Global.Package["Fish"] != 0)
        {
            text2.text = text2.text + "Fish: " + Global.Package["Fish"] + "\n";
        }

        if (Global.Package["Bread"] != 0)
        {
            text2.text = text2.text + "Bread: " + Global.Package["Bread"] + "\n";
        }

        if (Global.Package["Beef"] != 0)
        {
            text2.text = text2.text + "Beef: " + Global.Package["Beef"] + "\n";
        }

        if (Global.Package["Wood"] != 0)
        {
            text2.text = text2.text + "Wood: " + Global.Package["Wood"] + "\n";
        }

        if (Global.Package["Tea"] != 0)
        {
            text2.text = text2.text + "Tea: " + Global.Package["Tea"] + "\n";
        }

        if (Global.Package["Kimono"] != 0)
        {
            text2.text = text2.text + "Kimono: " + Global.Package["Kimono"] + "\n";
        }

        if (Global.Package["Spice"] != 0)
        {
            text2.text = text2.text + "Spice: " + Global.Package["Spice"] + "\n";
        }

        if (Global.Package["Milk"] != 0)
        {
            text2.text = text2.text + "Milk: " + Global.Package["Milk"] + "\n";
        }

        if (Global.Package["Hat"] != 0)
        {
            text2.text = text2.text + "Hat: " + Global.Package["Hat"] + "\n";
        }

        if (Global.Package["Beer"] != 0)
        {
            text2.text = text2.text + "Beer: " + Global.Package["Beer"] + "\n";
        }

        if (Global.Package["Wine"] != 0)
        {
            text2.text = text2.text + "Wine: " + Global.Package["Wine"] + "\n";
        }

        if (Global.Package["Fur"] != 0)
        {
            text2.text = text2.text + "Fur: " + Global.Package["Fur"] + "\n";
        }

        if (Global.Package["Handcraft"] != 0)
        {
            text2.text = text2.text + "Handcraft: " + Global.Package["Handcraft"] + "\n";
        }

        if (Global.Package["Compass"] != 0)
        {
            text2.text = text2.text + "Compass: " + Global.Package["Compass"] + "\n";
        }

        if (Global.Package["Chocolate"] != 0)
        {
            text2.text = text2.text + "Chocolate: " + Global.Package["Chocolate"] + "\n";
        }

        if (Global.Package["Jeans"] != 0)
        {
            text2.text = text2.text + "Jeans: " + Global.Package["Jeans"] + "\n";
        }

        if (Global.Package["Jewery"] != 0)
        {
            text2.text = text2.text + "Jewery: " + Global.Package["Jewery"] + "\n";
        }

        if (Global.Package["Sausage"] != 0)
        {
            text2.text = text2.text + "Sausage: " + Global.Package["Sausage"] + "\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
