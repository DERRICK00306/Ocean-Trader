using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timemoney : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    // Start is called before the first frame update
    /*void Start()
    {
        Text1 = transform.GetComponent<TextMeshProUGUI>();
    }*/

    // Update is called once per frame
    void Update()
    {
        int moneyoutput = Global.Money;
        int carryoutput = Global.Carry;
        Text1.text = "" + moneyoutput;
        Text2.text = "" + carryoutput + "/" + Global.MaxLoad;
        Text3.text = timer.countyear + " / " + timer.countmonth;
    }
}
