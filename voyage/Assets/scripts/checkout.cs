using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class checkout : MonoBehaviour
{
    public Text experience, wealth, ships, chinatowns;
    public Image a;
    public Sprite medal, cross;
    // Start is called before the first frame update
    void Start()
    {
        wealth.text = Global.Money.ToString();
        int china = 0;
        int Ships = 0;
        int e;
        foreach(var city in Global.ChinaTown)
        {
            if (city.Value == true) {
                china++;
            }
        }
        foreach(var ship in Global.ShipStatus)
        {
            if (ship.Value == true)
            {
                Ships++;
            }
        }
        e = timer.countyear - 1750;
        chinatowns.text = china.ToString();
        experience.text = e.ToString();
        ships.text = Ships.ToString();

        if (china > 4)
        {
            a.sprite = medal;

        }
        else {
            a.sprite = cross;
        }
    }

    public void quit()
    {
        Application.Quit();
    }


    // Update is called once per frame

}
