using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public static int count = 0;
    public static int countday = 1;
    public static int countmonth = 1;
    public static int countyear = 1750;
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
        if (count == 1600)
        {
            countday = countday + 1;
            count = 0;
        }
        if (countday == 31 && countmonth == 1)
        {
            countday = 1;
            countmonth = 2;
        }
        if (countday == 28 && countmonth == 2)
        {
            countday = 1;
            countmonth = 3;
        }
        if (countday == 31 && countmonth == 3)
        {
            countday = 1;
            countmonth = 4;
        }
        if (countday == 30 && countmonth == 4)
        {
            countday = 1;
            countmonth = 5;
        }
        if (countday == 31 && countmonth == 5)
        {
            countday = 1;
            countmonth = 6;
        }
        if (countday == 30 && countmonth == 6)
        {
            countday = 1;
            countmonth = 7;
        }
        if (countday == 31 && countmonth == 7)
        {
            countday = 1;
            countmonth = 8;
        }
        if (countday == 31 && countmonth == 8)
        {
            countday = 1;
            countmonth = 9;
        }
        if (countday == 30 && countmonth == 9)
        {
            countday = 1;
            countmonth = 10;
        }
        if (countday == 31 && countmonth == 10)
        {
            countday = 1;
            countmonth = 11;
        }
        if (countday == 30 && countmonth == 11)
        {
            countday = 1;
            countmonth = 12;
        }
        if (countday == 31 && countmonth == 12)
        {
            countday = 1;
            countmonth = 1;
            countyear = countyear + 1;
        }
        if (countyear == 1810)
        {
            Debug.Log("Finish!");
        }
    }
}
