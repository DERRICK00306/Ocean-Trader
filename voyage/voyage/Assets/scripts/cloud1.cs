using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud1 : MonoBehaviour
{
    public float speed_x = 3, speed_y = 1;
    public double stop_x_1 = -1, stop_x_2 = -1.1;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 v = rb.velocity;
        v.x = speed_x;
        v.y = speed_y;
        rb.velocity = v;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D> ();
        Vector2 v = rb.position;
        if (stop_x_2 <= v.x  && v.x <= stop_x_1)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
