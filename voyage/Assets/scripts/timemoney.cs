using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timemoney : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    // Start is called before the first frame update
    void Start()
    {
        Text1 = transform.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int moneyoutput = sail.totalmoney;
        int carryoutput = sail.carry;
        Text1.text = "Money: " + moneyoutput + " ;Carry: "+carryoutput + "/500";
    }
}
