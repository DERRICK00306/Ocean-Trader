using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Price : MonoBehaviour
{
    public int quantity1, quantity2, quantity3, quantity4, quantity5, quantity6,
               quantity7, quantity8, quantity9, quantity10, quantity11, quantity12,
               quantity13, quantity14;
    public int total1, total2, total3, total4, total5, total6, total7, total8,
               total9, total10, total11, total12, total13, total14;
    public GameObject warning;
    // Start is called before the first frame update
    public string city_name;
    public Text price_text1, price_text2, price_text3, price_text4, price_text5, price_text6, price_text7,
                price_text8, price_text9, price_text10, price_text11, price_text12, price_text13, price_text14;


    void Start()
    {
        price_text1.text = Global.price[city_name]["Kimono"].ToString();
        price_text2.text = Global.price[city_name]["Spice"].ToString();
        price_text3.text = Global.price[city_name]["Tea"].ToString();
        price_text4.text = Global.price[city_name]["Handcraft"].ToString();
        price_text5.text = Global.price[city_name]["Beef"].ToString();
        price_text6.text = Global.price[city_name]["Milk"].ToString();
        price_text7.text = Global.price[city_name]["Chocolate"].ToString();
        price_text8.text = Global.price[city_name]["Corn"].ToString();
        price_text9.text = Global.price[city_name]["Fish"].ToString();
        price_text10.text = Global.price[city_name]["Bread"].ToString();
        price_text11.text = Global.price[city_name]["Wine"].ToString();
        price_text12.text = Global.price[city_name]["Jewery"].ToString();
        price_text13.text = Global.price[city_name]["Wood"].ToString();
        price_text14.text = Global.price[city_name]["Fur"].ToString();
    }

    // Update is called once per frame
    public void Buy1()
    {
        if (total1 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Kimono"] += quantity1 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            } else
            {
                Global.Package["Kimono"] += quantity1;
            }
                
            Global.Money -= total1;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell1()
    {
        if (quantity1 <= Global.Package["Kimono"])
        {
            Global.Package["Kimono"] -= quantity1;
            Global.Money += total1;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Buy2()
    {
        if (total2 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Spice"] += quantity2 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Spice"] += quantity2;
            }
            Global.Money -= total2;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell2()
    {
        if (quantity2 <= Global.Package["Spice"])
        {
            Global.Package["Spice"] -= quantity2;
            Global.Money += total2;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy3()
    {
        if (total3 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Tea"] += quantity3 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Tea"] += quantity3;
            }
            Global.Money -= total3;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell3()
    {
        if (quantity3 <= Global.Package["Tea"])
        {
            Global.Package["Tea"] -= quantity3;
            Global.Money += total3;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Buy4()
    {
        if (total4 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Handcraft"] += quantity4 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Handcraft"] += quantity4;
            }
            Global.Money -= total4;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell4()
    {
        if (quantity4 <= Global.Package["Handcraft"])
        {
            Global.Package["Handcraft"] -= quantity4;
            Global.Money += total4;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy5()
    {
        if (total5 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Beef"] += quantity5 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Beef"] += quantity5;
            }
            Global.Money -= total5;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell5()
    {
        if (quantity5 <= Global.Package["Beef"])
        {
            Global.Package["Beef"] -= quantity5;
            Global.Money += total5;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy6()
    {
        if (total6 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Milk"] += quantity6 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Milk"] += quantity6;
            }
            Global.Money -= total6;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell6()
    {
        if (quantity6 <= Global.Package["Milk"])
        {
            Global.Package["Milk"] -= quantity6;
            Global.Money += total6;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Buy7()
    {
        if (total7 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Chocolate"] += quantity7 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Chocolate"] += quantity7;
            }
            Global.Money -= total7;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell7()
    {
        if (quantity7 <= Global.Package["Chocolate"])
        {
            Global.Package["Chocolate"] -= quantity7;
            Global.Money += total7;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy8()
    {
        if (total8 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Corn"] += quantity8 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Corn"] += quantity8;
            }
            Global.Money -= total8;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell8()
    {
        if (quantity8 <= Global.Package["Corn"])
        {
            Global.Package["Corn"] -= quantity8;
            Global.Money += total8;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy9()
    {
        if (total9 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Fish"] += quantity9 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Fish"] += quantity9;
            }
            Global.Money -= total9;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell9()
    {
        if (quantity9 <= Global.Package["Fish"])
        {
            Global.Package["Fish"] -= quantity9;
            Global.Money += total9;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy10()
    {
        if (total10 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Bread"] += quantity10 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Bread"] += quantity10;
            }
            Global.Money -= total10;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell10()
    {
        if (quantity1 <= Global.Package["Bread"])
        {
            Global.Package["Bread"] -= quantity10;
            Global.Money += total10;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Buy11()
    {
        if (total11 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Wine"] += quantity11 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Wine"] += quantity11;
            }
            Global.Money -= total11;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell11()
    {
        if (quantity11 <= Global.Package["Wine"])
        {
            Global.Package["Wine"] -= quantity11;
            Global.Money += total11;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy12()
    {
        if (total12 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Jewery"] += quantity12 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Jewery"] += quantity12;
            }
            Global.Money -= total12;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell12()
    {
        if (quantity12 <= Global.Package["Jewery"])
        {
            Global.Package["Jewery"] -= quantity12;
            Global.Money += total12;
        }
        else
        {
            Instantiate(warning);
        }
    }

    public void Buy13()
    {
        if (total13 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Wood"] += quantity13 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Wood"] += quantity13;
            }
            Global.Money -= total13;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell13()
    {
        if (quantity13 <= Global.Package["Wood"])
        {
            Global.Package["Wood"] -= quantity13;
            Global.Money += total13;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Buy14()
    {
        if (total14 <= Global.Money)
        {
            if (Global.GameAttribute["Reputation"] > 0)
            {
                Global.Package["Fur"] += quantity14 + Global.GameAttribute["Reputation"];
                Global.GameAttribute["Reputation"] = 0;
            }
            else
            {
                Global.Package["Fur"] += quantity14;
            }
            Global.Money -= total14;
        }
        else
        {
            Instantiate(warning);
        }
    }
    public void Sell14()
    {
        if (quantity14 <= Global.Package["Fur"])
        {
            Global.Package["Fur"] -= quantity14;
            Global.Money += total14;
        }
        else
        {
            Instantiate(warning);
        }
    }
}
