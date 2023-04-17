using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
        foreach(var city in Global.ChinaTown)
        {
            if (city.Value == true) {
                china++;
            }
        }
        chinatowns.text = china.ToString();
        experience.text = 3.ToString();
        ships.text = 2.ToString();

        if (china > 3)
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
