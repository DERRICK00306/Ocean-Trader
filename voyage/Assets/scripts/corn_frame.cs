using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corn_frame : MonoBehaviour
{
    public GameObject frame;
    // Start is called before the first frame update
    public void loadframe()
    {
        Instantiate(frame);
    }
}
