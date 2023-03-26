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
    public void Start()
    {
        int new_price = 60;
        price_text.text = new_price.ToString();
    }
  
    public void Buy() { 
    
    }
    public void Sell()
    {

    }
}
