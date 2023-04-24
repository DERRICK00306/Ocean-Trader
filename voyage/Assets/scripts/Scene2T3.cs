using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2T3 : MonoBehaviour
{
    public string Scene_Name;
    public GameObject cloud1, cloud2;
    public GameObject warning1;
    public GameObject warning2;
    public AudioSource audio_source;
    public GameObject checkout;
    public GameObject warning3;
    public GameObject d;

    // Start is called before the first frame update


    public void CheckChangeScene()
    {


        


        int truecost = Global.Cost;
        if (Global.GameAttribute["Strength"] >= 10)
        {
            truecost -= 50;
            if (Global.counttime > 3600)
            {
                truecost = Global.Cost;
                Global.GameAttribute["Strength"] = 0;
            }
        }
        
   
        int carrySum = 0;
        foreach (var value in Global.Package.Values)
        {

            carrySum += value;
        }

        Global.Carry = carrySum;

        
        if (Global.Carry == 0 && Global.Money <= 0)
        {
            Instantiate(checkout);
        }

        else
        {
            if (Global.MaxLoad > 0)
            {


                if (Global.Carry <= Global.MaxLoad)
                {
                    if (Global.Carry == 0)
                    {
                        FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
                        Instantiate(warning3);
                    }
                    else
                    {
                        Global.Money -= truecost;
                        FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect1();
                        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
                        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
                        Instantiate(audio_source);
                        
                        Global.CurrentScene = "Map";
                        Invoke("change", 1);
                    }
                    
                }
                else
                {
                    FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
                    Instantiate(warning2);
                }

            }
            else
            {
                FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();
                Instantiate(warning1);
            }
        }
    }

    public void IgnoreWarning()
    {
        Global.NewGame = false;

        int truecost = Global.Cost;
        if (Global.GameAttribute["Strength"] >= 10)
        {
            truecost -= 50;
            if (Global.counttime > 3600)
            {
                truecost = Global.Cost;
                Global.GameAttribute["Strength"] = 0;
            }
        }
        Global.Money -= truecost;
        if (d != null) d.SetActive(false);
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("change", 1);
    }

    public void change_scene()
    {
        if (d != null) d.SetActive(false);
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("change", 1);
    }

    public void change() { SceneManager.LoadScene(Scene_Name); }

    public void ChangeCurrent()
    {
        SceneManager.LoadScene(Global.CurrentScene);
    }

    public void ChangePre() { SceneManager.LoadScene(Global.PreviousScene); }

    public void change_to_previous_scene()
    {
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("ChangePre", 1);
    }

    public void continue_game()
    {
        if (Global.Count == 0)
        {
            sail.change = 0;
        }
        else sail.change = 1;
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("ChangeCurrent", 1);
    }

    public void new_game()
    {
        Global.CurrentScene = "Story";
        Global.NewGame = false;
        sail.change = 0;
        timer.count = 0;
        timer.countday = 1;
        timer.countmonth = 1;
        timer.countyear = 1750;
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("change", 1);
    }
}