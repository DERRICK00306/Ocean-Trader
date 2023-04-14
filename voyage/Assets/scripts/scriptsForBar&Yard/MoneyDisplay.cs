using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyDisplay : MonoBehaviour
{
    private int money;
    public TextMeshProUGUI moneyPanelText;
    // Start is called before the first frame update
    void Start()
    {
        money = Global.Money;
        moneyPanelText.text = money.ToString() + "$";
    }

    // Update is called once per frame
    void Update()
    {
        money = Global.Money;
        moneyPanelText.text = money.ToString() + "$";
    }
}
