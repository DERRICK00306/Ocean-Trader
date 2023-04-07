using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject[] UISet;
    

    public void SetUI()
    {
        foreach (GameObject UI in UISet)
        {
            UI.SetActive(true);
        }
    }

    public void UnsetUI()
    {
        foreach (GameObject UI in UISet)
        {
            UI.SetActive(false);
        }
    }

    public void ChangeStateUI()
    {
        foreach (GameObject UI in UISet)
        {
            if (UI.activeInHierarchy != true)
            {
                UI.SetActive(true);
            }
            else
            {
                UI.SetActive(false);
            }
        }
    }

}
