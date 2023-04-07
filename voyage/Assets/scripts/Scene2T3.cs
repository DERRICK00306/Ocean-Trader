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
    public void change_scene()
    {
        Instantiate(cloud1, new Vector2(-18, -6), Quaternion.identity);
        Instantiate(cloud2, new Vector2(18, 8), Quaternion.identity);
        Instantiate(audio_source);
        Invoke("change", 3);
    }

    public void change() { SceneManager.LoadScene(Scene_Name); }

}