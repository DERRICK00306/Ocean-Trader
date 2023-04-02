using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChinaTown : MonoBehaviour
{
    public GameObject IsBuilt;
    public GameObject NotBuilt;
    public string city_name;
    public GameObject warning;
    // Start is called before the first frame update
    public void Display() {
        if (Global.ChinaTown[city_name] == true)
        {
            Instantiate(IsBuilt);
        }
        else {
               Instantiate(NotBuilt);
        }
    }
}
