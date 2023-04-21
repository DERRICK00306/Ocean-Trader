using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public static int count = 0;
    public static int countday = 1;
    public static int countmonth = 1;
    public static int countyear = 1750;
    public GameObject a;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = 60;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1;
        if (count == 100 && countmonth != 12)
        {
            countmonth = countmonth + 1;
            count = 0;
        }
        if (count == 100 && countmonth == 12)
        {
            countmonth = 1;
            count = 0;
            countyear = countyear + 1;
        }
        
        if (countyear == 1800)
        {
            Instantiate(a);
        }
    }
}
