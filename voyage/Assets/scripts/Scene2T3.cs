using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2T3 : MonoBehaviour
{
    public string Scene_Name;
    // Start is called before the first frame update
    public void change_scene()
    {
        SceneManager.LoadScene(Scene_Name);
        GameObject.Find("ship1").transform.position = GameObject.Find("dontdestroy").transform.position;
    }
    
}
