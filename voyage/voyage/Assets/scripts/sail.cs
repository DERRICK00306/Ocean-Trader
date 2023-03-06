using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sail : MonoBehaviour
{
    public GameObject[] HKSingapore;
    public GameObject[] HKTokyo;
    string route;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Singapore")
        {

            if (transform.position == HKSingapore[0].transform.position)
            {
                route = "0-1";
            }
        }




        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Hong Kong")
        {

            if (transform.position == HKSingapore[2].transform.position)
            {
                route = "1-0";
            }

            if (transform.position == HKTokyo[3].transform.position)
            {
                route = "2-0";
            }
        }



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Tokyo")
        {

            if (transform.position == HKTokyo[0].transform.position)
            {
                route = "0-2";
            }
        }











        if (route == "0-1")
        {
            if (i == 0 && transform.position != HKSingapore[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKSingapore[1].transform.position, 0.01f);
            }
            if (transform.position == HKSingapore[1].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, HKSingapore[2].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != HKSingapore[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKSingapore[2].transform.position, 0.01f);
            }
            if (transform.position == HKSingapore[2].transform.position)
            {
                route = "";
                i = 0;
            }
        }





        if (route == "1-0")
        {
            if (i == 0 && transform.position != HKSingapore[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKSingapore[1].transform.position, 0.01f);
            }
            if (transform.position == HKSingapore[1].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, HKSingapore[0].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != HKSingapore[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKSingapore[0].transform.position, 0.01f);
            }
            if (transform.position == HKSingapore[0].transform.position)
            {
                route = "";
                i = 0;
            }
        }



        if (route == "0-2")
        {
            if (i == 0 && transform.position != HKTokyo[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[1].transform.position, 0.01f);
            }
            if (transform.position == HKTokyo[1].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[2].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != HKTokyo[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[2].transform.position, 0.01f);
            }
            if (transform.position == HKTokyo[2].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[3].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != HKTokyo[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[3].transform.position, 0.01f);
            }
            if (transform.position == HKTokyo[3].transform.position)
            {
                i = 0;
                route = "";
            }
        }



        if (route == "2-0")
        {
            if (i == 0 && transform.position != HKTokyo[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[2].transform.position, 0.01f);
            }
            if (transform.position == HKTokyo[2].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[1].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != HKTokyo[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[1].transform.position, 0.01f);
            }
            if (transform.position == HKTokyo[1].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[0].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != HKTokyo[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, HKTokyo[0].transform.position, 0.01f);
            }
            if (transform.position == HKTokyo[0].transform.position)
            {
                i = 0;
                route = "";
            }
        }

    }
}