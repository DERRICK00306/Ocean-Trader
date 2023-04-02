using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Quantity : MonoBehaviour
{
    // Start is called before the first frame update
    public recorder A;
    public Text total_text;
    public string city_name;
    public string commodity;

    public void Start()
    {
        total_text.text = Global.price[city_name][commodity].ToString();
    }
    public void Getinput(string input)
    {
        A.quantity = int.Parse(input);
        A.total = A.quantity * Global.price[city_name][commodity];
        total_text.text = A.total.ToString();
    }

}
