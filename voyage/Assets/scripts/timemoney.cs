using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timemoney : MonoBehaviour
{
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = transform.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int moneyoutput = GameObject.Find("ship1").GetComponent<sail>().totalmoney;
        int carryoutput = GameObject.Find("ship1").GetComponent<sail>().carry;
        Text.text = "Money: " + moneyoutput + " ;Carry: "+carryoutput + "/500";
    }
}
