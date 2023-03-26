using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Quantity : MonoBehaviour
{
    // Start is called before the first frame update
    public recorder A;
    public Text total_text;

    public void Start()
    {
        total_text.text = "60";
    }
    public void Getinput(string input)
    {
        A.quantity = int.Parse(input);
        A.total = A.quantity * 60;
        total_text.text = A.total.ToString();
    }

}
