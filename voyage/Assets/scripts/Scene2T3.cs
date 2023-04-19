using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2T3 : MonoBehaviour
{
    public string Scene_Name;
    public GameObject cloud1, cloud2;
    public AudioSource audio_source;
    // Start is called before the first frame update


    public void CheckChangeScene()
    {
        if (Global.MaxLoad > 0)
        {
            Global.Money -= Global.Cost;
            FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect1();
            Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
            Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
            Instantiate(audio_source);
            Invoke("change", 1);
        }
        else FindObjectOfType<Camera>().GetComponent<PlaySound>().PlayThisSoundEffect2();

    }



    public void change_scene()
    {
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("change", 1);
    }

    public void change() { SceneManager.LoadScene(Scene_Name); }

    public void ChangePre() { SceneManager.LoadScene(Global.PreviousScene); }

    public void change_to_previous_scene()
    {
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("ChangePre", 1);
    }
}