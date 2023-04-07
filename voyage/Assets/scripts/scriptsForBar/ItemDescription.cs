using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemDescription : MonoBehaviour
{
    
    public Image itemDescriptionBox;
   
    public Sprite icon;

    

    public void onButtonClick()
    {
        itemDescriptionBox.sprite = icon;  
    }
    
}
