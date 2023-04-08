using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quantity : MonoBehaviour
{
    public Price A;
    public string city_name;
    public string commodity1, commodity2, commodity3, commodity4, commodity5, commodity6, commodity7, commodity8, commodity9, commodity10,
                  commodity11, commodity12, commodity13, commodity14;

    // Start is called before the first frame update
    public void Getinput1(string input)
    {
        A.quantity1 = int.Parse(input);
        A.total1 = A.quantity1 * Global.price[city_name][commodity1];
    }
    public void Getinput2(string input)
    {
        A.quantity2 = int.Parse(input);
        A.total2 = A.quantity2 * Global.price[city_name][commodity2];
    }
    public void Getinput3(string input)
    {
        A.quantity3 = int.Parse(input);
        A.total3 = A.quantity3 * Global.price[city_name][commodity3];
    }
    public void Getinput4(string input)
    {
        A.quantity4 = int.Parse(input);
        A.total4 = A.quantity4 * Global.price[city_name][commodity4];
    }
    public void Getinput5(string input)
    {
        A.quantity5 = int.Parse(input);
        A.total5 = A.quantity5 * Global.price[city_name][commodity5];
    }
    public void Getinput6(string input)
    {
        A.quantity6 = int.Parse(input);
        A.total6 = A.quantity6 * Global.price[city_name][commodity6];
    }
    public void Getinput7(string input)
    {
        A.quantity7 = int.Parse(input);
        A.total7 = A.quantity7 * Global.price[city_name][commodity7];
    }
    public void Getinput8(string input)
    {
        A.quantity8 = int.Parse(input);
        A.total8 = A.quantity8 * Global.price[city_name][commodity8];
    }
    public void Getinput9(string input)
    {
        A.quantity9 = int.Parse(input);
        A.total9 = A.quantity9 * Global.price[city_name][commodity9];
    }
    public void Getinput10(string input)
    {
        A.quantity10 = int.Parse(input);
        A.total10 = A.quantity10 * Global.price[city_name][commodity10];
    }
    public void Getinput11(string input)
    {
        A.quantity11 = int.Parse(input);
        A.total11 = A.quantity11 * Global.price[city_name][commodity11];
    }
    public void Getinput12(string input)
    {
        A.quantity12 = int.Parse(input);
        A.total12 = A.quantity12 * Global.price[city_name][commodity12];
    }
    public void Getinput13(string input)
    {
        A.quantity13 = int.Parse(input);
        A.total13 = A.quantity13 * Global.price[city_name][commodity13];
    }
    public void Getinput14(string input)
    {
        A.quantity14 = int.Parse(input);
        A.total14 = A.quantity14 * Global.price[city_name][commodity14];
    }


}
