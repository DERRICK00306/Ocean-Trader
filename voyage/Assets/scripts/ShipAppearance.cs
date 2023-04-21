using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipAppearance : MonoBehaviour
{
    public GameObject ship;

    public Sprite shipIcon0;
    public Sprite shipIcon1;
    public Sprite shipIcon2;
    public Sprite shipIcon3;
    public Sprite shipIcon4;
    public Sprite shipIcon5;
    public Sprite shipIcon6;

    // Start is called before the first frame update
    void Start()
    {
        if (Global.ShipSelect["Ship1"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon0;
        }
        else if (Global.ShipSelect["Ship2"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon1;
        }
        else if (Global.ShipSelect["Ship3"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon2;
        }
        else if (Global.ShipSelect["Ship4"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon3;
        }
        else if (Global.ShipSelect["Ship5"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon4;
        }
        else if (Global.ShipSelect["Ship6"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon5;
        }
        else if (Global.ShipSelect["Ship7"] == true)
        {
            ship.GetComponent<SpriteRenderer>().sprite = shipIcon6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
