using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sail : MonoBehaviour
{
    public GameObject[] routes;
    public GameObject[] ports;
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

            if (transform.position == ports[0].transform.position)
            {
                route = "0-1";
            }
            if (transform.position == ports[2].transform.position)
            {
                route = "2-1";
            }
            if (transform.position == ports[3].transform.position)
            {
                route = "1-3";
            }
        }




        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Hong Kong")
        {

            if (transform.position == ports[1].transform.position)
            {
                route = "1-0";
            }

            if (transform.position == ports[2].transform.position)
            {
                route = "2-0";
            }

            if (transform.position == ports[3].transform.position)
            {
                route = "3-0";
            }
        }



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Tokyo")
        {

            if (transform.position == ports[0].transform.position)
            {
                route = "0-2";
            }
            if (transform.position == ports[1].transform.position)
            {
                route = "1-2";
            }
            if (transform.position == ports[3].transform.position)
            {
                route = "3-2";
            }
        }


        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Sydney")
        {

            if (transform.position == ports[0].transform.position)
            {
                route = "0-3";
            }
            if (transform.position == ports[1].transform.position)
            {
                route = "1-3";
            }
            if (transform.position == ports[2].transform.position)
            {
                route = "2-3";
            }
        }




        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Good Hope")
        {

            if (transform.position == ports[5].transform.position)
            {
                route = "5-4";
            }
            if (transform.position == ports[6].transform.position)
            {
                route = "6-4";
            }

        }


        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Alexandria")
        {

            if (transform.position == ports[4].transform.position)
            {
                route = "4-5";
            }
            if (transform.position == ports[6].transform.position)
            {
                route = "6-5";
            }
        }



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Casablanca")
        {

            if (transform.position == ports[4].transform.position)
            {
                route = "4-6";
            }
            if (transform.position == ports[5].transform.position)
            {
                route = "5-6";
            }
        }




        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "London")
        {

            if (transform.position == ports[8].transform.position)
            {
                route = "8-7";
            }
            if (transform.position == ports[9].transform.position)
            {
                route = "9-7";
            }
        }


        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Hamburg")
        {

            if (transform.position == ports[7].transform.position)
            {
                route = "7-8";
            }
            if (transform.position == ports[9].transform.position)
            {
                route = "9-8";
            }
        }


        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Barcelona")
        {

            if (transform.position == ports[7].transform.position)
            {
                route = "7-9";
            }
            if (transform.position == ports[8].transform.position)
            {
                route = "8-9";
            }
        }



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "New York")
        {

            if (transform.position == ports[11].transform.position)
            {
                route = "11-10";
            }
            if (transform.position == ports[12].transform.position)
            {
                route = "12-10";
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "13-10";
            }
        }



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Vencouver")
        {

            if (transform.position == ports[10].transform.position)
            {
                route = "10-11";
            }
            if (transform.position == ports[12].transform.position)
            {
                route = "12-11";
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "13-11";
            }
        }




        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "San Francisco")
        {

            if (transform.position == ports[10].transform.position)
            {
                route = "10-12";
            }
            if (transform.position == ports[11].transform.position)
            {
                route = "11-12";
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "13-12";
            }
        }



        if (Input.GetMouseButton(0) && hit.collider != null && hit.collider.gameObject.name == "Brenos Aries")
        {

            if (transform.position == ports[10].transform.position)
            {
                route = "10-13";
            }
            if (transform.position == ports[11].transform.position)
            {
                route = "11-13";
            }
            if (transform.position == ports[12].transform.position)
            {
                route = "12-13";
            }
        }













        if (route == "0-1")
        {
            if (i == 0 && transform.position != routes[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[0].transform.position, 0.01f);
            }
            if (transform.position == routes[0].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, 0.01f);
            }
            if (transform.position == ports[1].transform.position)
            {
                route = "";
                i = 0;
            }
        }





        if (route == "1-0")
        {
            if (i == 0 && transform.position != routes[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[0].transform.position, 0.01f);
            }
            if (transform.position == routes[0].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.01f);
            }
            if (transform.position == ports[0].transform.position)
            {
                route = "";
                i = 0;
            }
        }



        if (route == "0-2")
        {
            if (i == 0 && transform.position != routes[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[1].transform.position, 0.01f);
            }
            if (transform.position == routes[1].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[2].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[2].transform.position, 0.01f);
            }
            if (transform.position == routes[2].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, 0.01f);
            }
            if (transform.position == ports[2].transform.position)
            {
                i = 0;
                route = "";
            }
        }



        if (route == "2-0")
        {
            if (i == 0 && transform.position != routes[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[2].transform.position, 0.01f);
            }
            if (transform.position == routes[2].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[1].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[1].transform.position, 0.01f);
            }
            if (transform.position == routes[1].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.01f);
            }
            if (transform.position == ports[0].transform.position)
            {
                i = 0;
                route = "";
            }
        }




        if (route == "0-3")
        {
            if (i == 0 && transform.position != routes[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[3].transform.position, 0.01f);
            }
            if (transform.position == routes[3].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, 0.01f);
            }
            if (transform.position == routes[4].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[5].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[5].transform.position, 0.01f);
            }
            if (transform.position == routes[5].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, 0.01f);
            }
            if (transform.position == ports[3].transform.position)
            {
                i = 0;
                route = "";
            }
        }




        if (route == "3-0")
        {
            if (i == 0 && transform.position != routes[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[5].transform.position, 0.01f);
            }
            if (transform.position == routes[5].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, 0.01f);
            }
            if (transform.position == routes[4].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[3].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[3].transform.position, 0.01f);
            }
            if (transform.position == routes[3].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.01f);
            }
            if (transform.position == ports[0].transform.position)
            {
                i = 0;
                route = "";
            }
        }





        if (route == "1-2")
        {
            if (i == 0 && transform.position != routes[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[6].transform.position, 0.01f);
            }
            if (transform.position == routes[6].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[7].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[7].transform.position, 0.01f);
            }
            if (transform.position == routes[7].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, 0.01f);
            }
            if (transform.position == ports[2].transform.position)
            {
                i = 0;
                route = "";
            }
        }







        if (route == "2-1")
        {
            if (i == 0 && transform.position != routes[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[7].transform.position, 0.01f);
            }
            if (transform.position == routes[7].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[6].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[6].transform.position, 0.01f);
            }
            if (transform.position == routes[6].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, 0.01f);
            }
            if (transform.position == ports[1].transform.position)
            {
                i = 0;
                route = "";
            }
        }




        if (route == "1-3")
        {
            if (i == 0 && transform.position != routes[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[8].transform.position, 0.01f);
            }
            if (transform.position == routes[8].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, 0.01f);
            }
            if (transform.position == routes[9].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[10].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[10].transform.position, 0.01f);
            }
            if (transform.position == routes[10].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, 0.01f);
            }
            if (transform.position == ports[3].transform.position)
            {
                i = 0;
                route = "";
            }
        }





        if (route == "3-1")
        {
            if (i == 0 && transform.position != routes[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[10].transform.position, 0.01f);
            }
            if (transform.position == routes[10].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, 0.01f);
            }
            if (transform.position == routes[9].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[8].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[8].transform.position, 0.01f);
            }
            if (transform.position == routes[8].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, 0.01f);
            }
            if (transform.position == ports[1].transform.position)
            {
                i = 0;
                route = "";
            }
        }








        if (route == "2-3")
        {
            if (i == 0 && transform.position != routes[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[11].transform.position, 0.01f);
            }
            if (transform.position == routes[11].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[12].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[12].transform.position, 0.01f);
            }
            if (transform.position == routes[12].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, 0.01f);
            }
            if (transform.position == ports[3].transform.position)
            {
                i = 0;
                route = "";
            }
        }







        if (route == "3-2")
        {
            if (i == 0 && transform.position != routes[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[12].transform.position, 0.01f);
            }
            if (transform.position == routes[12].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[11].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[11].transform.position, 0.01f);
            }
            if (transform.position == routes[11].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, 0.01f);
            }
            if (transform.position == ports[2].transform.position)
            {
                i = 0;
                route = "";
            }
        }







        if (route == "4-5")
        {
            if (i == 0 && transform.position != routes[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[13].transform.position, 0.01f);
            }
            if (transform.position == routes[13].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[14].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, 0.01f);
            }
            if (transform.position == routes[14].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[15].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[15].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[15].transform.position, 0.01f);
            }
            if (transform.position == routes[15].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, 0.01f);
            }
            if (transform.position == ports[5].transform.position)
            {
                i = 0;
                route = "";
            }
        }








        if (route == "5-4")
        {
            if (i == 0 && transform.position != routes[15].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[15].transform.position, 0.01f);
            }
            if (transform.position == routes[15].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[14].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, 0.01f);
            }
            if (transform.position == routes[14].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[13].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[13].transform.position, 0.01f);
            }
            if (transform.position == routes[13].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, 0.01f);
            }
            if (transform.position == ports[4].transform.position)
            {
                i = 0;
                route = "";
            }
        }





        if (route == "4-6")
        {
            if (i == 0 && transform.position != routes[16].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[16].transform.position, 0.01f);
            }
            if (transform.position == routes[16].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, 0.01f);
            }
            if (transform.position == ports[6].transform.position)
            {
                route = "";
                i = 0;
            }
        }




        if (route == "6-4")
        {
            if (i == 0 && transform.position != routes[16].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[16].transform.position, 0.01f);
            }
            if (transform.position == routes[16].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, 0.01f);
            }
            if (transform.position == ports[4].transform.position)
            {
                route = "";
                i = 0;
            }
        }








        if (route == "5-6")
        {
            if (i == 0 && transform.position != routes[17].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[17].transform.position, 0.01f);
            }
            if (transform.position == routes[17].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[18].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[18].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[18].transform.position, 0.01f);
            }
            if (transform.position == routes[18].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, 0.01f);
            }
            if (transform.position == ports[6].transform.position)
            {
                i = 0;
                route = "";
            }
        }






        if (route == "6-5")
        {
            if (i == 0 && transform.position != routes[18].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[18].transform.position, 0.01f);
            }
            if (transform.position == routes[18].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[17].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[17].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[17].transform.position, 0.01f);
            }
            if (transform.position == routes[17].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != ports[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, 0.01f);
            }
            if (transform.position == ports[5].transform.position)
            {
                i = 0;
                route = "";
            }
        }





        if (route == "7-8")
        {
            if (i == 0 && transform.position != routes[19].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[19].transform.position, 0.01f);
            }
            if (transform.position == routes[19].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, 0.01f);
            }
            if (transform.position == ports[8].transform.position)
            {
                route = "";
                i = 0;
            }
        }




        if (route == "8-7")
        {
            if (i == 0 && transform.position != routes[19].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[19].transform.position, 0.01f);
            }
            if (transform.position == routes[19].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, 0.01f);
            }
            if (transform.position == ports[7].transform.position)
            {
                route = "";
                i = 0;
            }
        }









        if (route == "7-9")
        {
            if (i == 0 && transform.position != routes[20].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[20].transform.position, 0.01f);
            }
            if (transform.position == routes[20].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[21].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, 0.01f);
            }
            if (transform.position == routes[21].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[22].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[22].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[22].transform.position, 0.01f);
            }
            if (transform.position == routes[22].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, 0.01f);
            }
            if (transform.position == ports[9].transform.position)
            {
                i = 0;
                route = "";
            }
        }









        if (route == "9-7")
        {
            if (i == 0 && transform.position != routes[22].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[22].transform.position, 0.01f);
            }
            if (transform.position == routes[22].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[21].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, 0.01f);
            }
            if (transform.position == routes[21].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[20].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[20].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[20].transform.position, 0.01f);
            }
            if (transform.position == routes[20].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, 0.01f);
            }
            if (transform.position == ports[7].transform.position)
            {
                i = 0;
                route = "";
            }
        }






        if (route == "8-9")
        {
            if (i == 0 && transform.position != routes[23].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[23].transform.position, 0.01f);
            }
            if (transform.position == routes[23].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[24].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, 0.01f);
            }
            if (transform.position == routes[24].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[25].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[25].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[25].transform.position, 0.01f);
            }
            if (transform.position == routes[25].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, 0.01f);
            }
            if (transform.position == ports[9].transform.position)
            {
                i = 0;
                route = "";
            }
        }







        if (route == "9-8")
        {
            if (i == 0 && transform.position != routes[25].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[25].transform.position, 0.01f);
            }
            if (transform.position == routes[25].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[24].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, 0.01f);
            }
            if (transform.position == routes[24].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[23].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[23].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[23].transform.position, 0.01f);
            }
            if (transform.position == routes[23].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, 0.01f);
            }
            if (transform.position == ports[8].transform.position)
            {
                i = 0;
                route = "";
            }
        }







        if (route == "10-11")
        {
            if (i == 0 && transform.position != routes[26].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[26].transform.position, 0.01f);
            }
            if (transform.position == routes[26].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[27].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, 0.01f);
            }
            if (transform.position == routes[27].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[28].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[28].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[28].transform.position, 0.01f);
            }
            if (transform.position == routes[28].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, 0.01f);
            }
            if (transform.position == ports[11].transform.position)
            {
                i = 0;
                route = "";
            }
        }







        if (route == "11-10")
        {
            if (i == 0 && transform.position != routes[28].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[28].transform.position, 0.01f);
            }
            if (transform.position == routes[28].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[27].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, 0.01f);
            }
            if (transform.position == routes[27].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[26].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[26].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[26].transform.position, 0.01f);
            }
            if (transform.position == routes[26].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, 0.01f);
            }
            if (transform.position == ports[10].transform.position)
            {
                i = 0;
                route = "";
            }
        }





        if (route == "10-12")
        {
            if (i == 0 && transform.position != routes[29].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[29].transform.position, 0.01f);
            }
            if (transform.position == routes[29].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[30].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, 0.01f);
            }
            if (transform.position == routes[30].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[31].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[31].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[31].transform.position, 0.01f);
            }
            if (transform.position == routes[31].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.01f);
            }
            if (transform.position == ports[12].transform.position)
            {
                i = 0;
                route = "";
            }
        }








        if (route == "12-10")
        {
            if (i == 0 && transform.position != routes[31].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[31].transform.position, 0.01f);
            }
            if (transform.position == routes[31].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[30].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, 0.01f);
            }
            if (transform.position == routes[30].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[29].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[29].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[29].transform.position, 0.01f);
            }
            if (transform.position == routes[29].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, 0.01f);
            }
            if (transform.position == ports[10].transform.position)
            {
                i = 0;
                route = "";
            }
        }




        if (route == "10-13")
        {
            if (i == 0 && transform.position != routes[32].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[32].transform.position, 0.01f);
            }
            if (transform.position == routes[32].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, 0.01f);
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "";
                i = 0;
            }
        }





        if (route == "13-10")
        {
            if (i == 0 && transform.position != routes[32].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[32].transform.position, 0.01f);
            }
            if (transform.position == routes[32].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, 0.01f);
            }
            if (transform.position == ports[10].transform.position)
            {
                route = "";
                i = 0;
            }
        }






        if (route == "11-12")
        {
            if (i == 0 && transform.position != routes[33].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[33].transform.position, 0.01f);
            }
            if (transform.position == routes[33].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.01f);
            }
            if (transform.position == ports[12].transform.position)
            {
                route = "";
                i = 0;
            }
        }






        if (route == "12-11")
        {
            if (i == 0 && transform.position != routes[33].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[33].transform.position, 0.01f);
            }
            if (transform.position == routes[33].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != ports[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, 0.01f);
            }
            if (transform.position == ports[11].transform.position)
            {
                route = "";
                i = 0;
            }
        }







        if (route == "11-13")
        {
            if (i == 0 && transform.position != routes[34].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[34].transform.position, 0.01f);
            }
            if (transform.position == routes[34].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[35].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, 0.01f);
            }
            if (transform.position == routes[35].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[36].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, 0.01f);
            }
            if (transform.position == routes[36].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[37].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != routes[37].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[37].transform.position, 0.01f);
            }
            if (transform.position == routes[37].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, 0.01f);
            }
            if (i == 4 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, 0.01f);
            }
            if (transform.position == ports[13].transform.position)
            {
                i = 0;
                route = "";
            }
        }










        if (route == "13-11")
        {
            if (i == 0 && transform.position != routes[37].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[37].transform.position, 0.01f);
            }
            if (transform.position == routes[37].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[36].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, 0.01f);
            }
            if (transform.position == routes[36].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[35].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, 0.01f);
            }
            if (transform.position == routes[35].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[34].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != routes[34].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[34].transform.position, 0.01f);
            }
            if (transform.position == routes[34].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, 0.01f);
            }
            if (i == 4 && transform.position != ports[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, 0.01f);
            }
            if (transform.position == ports[11].transform.position)
            {
                i = 0;
                route = "";
            }
        }











        if (route == "12-13")
        {
            if (i == 0 && transform.position != routes[38].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[38].transform.position, 0.01f);
            }
            if (transform.position == routes[38].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[39].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, 0.01f);
            }
            if (transform.position == routes[39].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[40].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, 0.01f);
            }
            if (transform.position == routes[40].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[41].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != routes[41].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[41].transform.position, 0.01f);
            }
            if (transform.position == routes[41].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, 0.01f);
            }
            if (i == 4 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, 0.01f);
            }
            if (transform.position == ports[13].transform.position)
            {
                i = 0;
                route = "";
            }
        }








        if (route == "13-12")
        {
            if (i == 0 && transform.position != routes[41].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[41].transform.position, 0.01f);
            }
            if (transform.position == routes[41].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, 0.01f);
            }
            if (i == 1 && transform.position != routes[40].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, 0.01f);
            }
            if (transform.position == routes[40].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, 0.01f);
            }
            if (i == 2 && transform.position != routes[39].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, 0.01f);
            }
            if (transform.position == routes[39].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[38].transform.position, 0.01f);
            }
            if (i == 3 && transform.position != routes[38].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[38].transform.position, 0.01f);
            }
            if (transform.position == routes[38].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.01f);
            }
            if (i == 4 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.01f);
            }
            if (transform.position == ports[12].transform.position)
            {
                i = 0;
                route = "";
            }
        }
    }
}