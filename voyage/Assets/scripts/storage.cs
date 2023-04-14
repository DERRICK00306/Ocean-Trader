using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class storage : MonoBehaviour
{
    public Text text1, text2, text3, text4, text5, text6, text7,
                text8, text9, text10, text11, text12, text13, text14;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = Global.Package["Kimono"].ToString();
        text2.text = Global.Package["Spice"].ToString();
        text3.text = Global.Package["Tea"].ToString();
        text4.text = Global.Package["Handcraft"].ToString();
        text5.text = Global.Package["Beef"].ToString();
        text6.text = Global.Package["Milk"].ToString();
        text7.text = Global.Package["Chocolate"].ToString();
        text8.text = Global.Package["Corn"].ToString();
        text9.text = Global.Package["Fish"].ToString();
        text10.text = Global.Package["Bread"].ToString();
        text11.text = Global.Package["Wine"].ToString();
        text12.text = Global.Package["Jewery"].ToString();
        text13.text = Global.Package["Wood"].ToString();
        text14.text = Global.Package["Fur"].ToString();
    }
}
