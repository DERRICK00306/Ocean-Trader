using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HK_Singapore : MonoBehaviour
{
    public GameObject[] routes;
    private int i = 0;
    private bool click = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0) && click == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                click = true;
            }

        }
        if (click == true)
        {
            if (transform.position != routes[i].transform.position)
            {
                MovePoints();
            }
            if (transform.position == routes[i].transform.position)
            {
                if (i < routes.Length - 1)
                {
                    i = i + 1;
                }
                MovePoints();
            }
        }
    }
    void MovePoints()
    {
        transform.position = Vector3.MoveTowards(transform.position, routes[i].transform.position, 0.01f);
    }
}
