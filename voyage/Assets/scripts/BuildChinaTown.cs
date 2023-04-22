using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildChinaTown : MonoBehaviour
{
    public GameObject CT_Frame;
    public string city_name;
    public GameObject warning;
    // Start is called before the first frame update
    public void Build() {
        if (Global.Money < 5000)
        {
            Instantiate(warning);
        }
        else {
            Global.Money -= 5000;

            Global.ChinaTown[city_name] = true;

            Destroy(CT_Frame);

        }
        
    }
}
