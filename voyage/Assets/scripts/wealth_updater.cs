using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wealth_updater : MonoBehaviour
{
    // Start is called before the first frame update
    public Text wealth;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wealth.text = Global.Money.ToString();        
    }
}
