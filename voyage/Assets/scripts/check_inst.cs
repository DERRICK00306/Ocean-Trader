using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_inst : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    public void ins()
    {
        Instantiate(a);
    }
}
