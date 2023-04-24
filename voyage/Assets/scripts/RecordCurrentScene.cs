using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordCurrentScene : MonoBehaviour
{
    public string currentScene;
    // Start is called before the first frame update
    void Start()
    {
        Global.CurrentScene = currentScene;
        if (Global.CurrentScene != "Hong_Kong" && Global.CurrentScene != "Map" && Global.CurrentScene != "Story")
        Global.Count++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
