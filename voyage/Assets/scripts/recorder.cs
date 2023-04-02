using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class recorder : MonoBehaviour
{
    //public Text price_text;
    public Text price_text;
    // Start is called before the first frame update
    public int quantity = 1;
    public int total;
    public string city_name;
    public string commodity;
    public GameObject warning;
    public void Start()
    {
        price_text.text = Global.price[city_name][commodity].ToString();
    }
  
    public void Buy() {
        Debug.Log(total);
        if (total < Global.Money)
        {
            Global.Package[commodity] += quantity;
            Global.Money -= total;
        } else
        {
            Instantiate(warning);
        }
    }
    public void Sell()
    {
        if (quantity <= Global.Package[commodity])
        {
            Global.Package[commodity] -= quantity;
            Global.Money += total;
        } else
        {
            Instantiate(warning);
        }
    }
}
