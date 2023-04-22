using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class timemoney : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;

    public TextMeshProUGUI Text4;
    public TextMeshProUGUI Text5;
    public TextMeshProUGUI Text6;
    public TextMeshProUGUI Text7;
    // Start is called before the first frame update
    /*void Start()
    {
        Text1 = transform.GetComponent<TextMeshProUGUI>();
    }*/

    // Update is called once per frame
    void Update()
    {

        int carrySum = 0;
        foreach (var value in Global.Package.Values)
        {

            carrySum += value;
        }

        Global.Carry = carrySum;

        int moneyoutput = Global.Money;
        int carryoutput = Global.Carry;
        Text1.text = "" + moneyoutput;
        Text2.text = "" + carryoutput + "/" + Global.MaxLoad;
        Text3.text = timer.countyear + " Y / " + timer.countmonth + " M";

        Text4.text = Global.GameAttribute["Speed"].ToString();
        Text5.text = Global.GameAttribute["Reputation"].ToString();
        Text6.text = Global.GameAttribute["Luck"].ToString();
        Text7.text = Global.GameAttribute["Strength"].ToString();

    }
}
