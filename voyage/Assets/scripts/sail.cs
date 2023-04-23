using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sail : MonoBehaviour
{
    public GameObject[] routes;
    public GameObject[] ports;
    string route;
    int i = 0;
    public static int change = 0;
    public static int arrival = 1;
    public static int portarrival = 0;
    public static int checkoutput = 0;

    float speed = 0;
    int check = Global.GameAttribute["Speed"];
    // Start is called before the first frame update

    void Awake()
    {
        if (sail.change == 1)
        {
            transform.position = remember.position;
        }

        if (sail.change == 0)
        {
            transform.position = ports[0].transform.position;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (sail.arrival == 1)
        {

        }
        Global.counttime = Global.counttime + 1;
        if (check == 0)
        {
            speed = 0.01f;
        }

        if (check == 100)
        {
            speed = 0.01f;
        }
        if (check == 110)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.01f;
                Global.GameAttribute["Speed"] = 100;
            }
            speed = 0.015f;
        }


        if (check == 200)
        {
            speed = 0.015f;
        }
        if (check == 210)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.015f;
                Global.GameAttribute["Speed"] = 200;
            }
            speed = 0.02f;
        }


        if (check == 500)
        {
            speed = 0.02f;
        }
        if (check == 510)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.02f;
                Global.GameAttribute["Speed"] = 500;
            }
            speed = 0.03f;
        }


        if (check == 800)
        {
            speed = 0.03f;
        }
        if (check == 810)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.03f;
                Global.GameAttribute["Speed"] = 800;
            }
            speed = 0.05f;
        }


        if (check == 1000)
        {
            speed = 0.05f;
        }
        if (check == 1010)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.05f;
                Global.GameAttribute["Speed"] = 1000;
            }
            speed = 0.06f;
        }


        if (check == 1500)
        {
            speed = 0.06f;
        }
        if (check == 1510)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.06f;
                Global.GameAttribute["Speed"] = 1500;
            }
            speed = 0.1f;
        }


        if (check == 3000)
        {
            speed = 0.1f;
        }
        if (check == 3010)
        {
            if (Global.counttime > 3600)
            {
                speed = 0.1f;
                Global.GameAttribute["Speed"] = 3000;
            }
            speed = 0.11f;
        }
        sail.change = 1;
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
                route = "3-1";
            }
            if (transform.position == ports[4].transform.position)
            {
                route = "4-1";
            }
            if (transform.position == ports[5].transform.position)
            {
                route = "5-1";
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
            if (transform.position == ports[12].transform.position)
            {
                route = "12-0";
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
            if (transform.position == ports[1].transform.position)
            {
                route = "1-4";
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "13-4";
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
            if (transform.position == ports[1].transform.position)
            {
                route = "1-5";
            }
            if (transform.position == ports[9].transform.position)
            {
                route = "9-5";
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
            if (transform.position == ports[9].transform.position)
            {
                route = "9-6";
            }
            if (transform.position == ports[10].transform.position)
            {
                route = "10-6";
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
            if (transform.position == ports[10].transform.position)
            {
                route = "10-7";
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
            if (transform.position == ports[6].transform.position)
            {
                route = "6-9";
            }
            if (transform.position == ports[5].transform.position)
            {
                route = "5-9";
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
            if (transform.position == ports[6].transform.position)
            {
                route = "6-10";
            }
            if (transform.position == ports[7].transform.position)
            {
                route = "7-10";
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
            if (transform.position == ports[0].transform.position)
            {
                route = "0-12";
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
            if (transform.position == ports[4].transform.position)
            {
                route = "4-13";
            }
            
        }













        if (route == "0-1")
        {
            if (i == 0 && transform.position != routes[0].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[0].transform.position, speed);
            }
            if (transform.position == routes[0].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (transform.position == ports[1].transform.position)
            {
                route = "";
                i = 0;
                port1.firstarrivalsingapore = 1;
                sail.arrival = 1;
                sail.portarrival = 1;
            }
        }





        if (route == "1-0")
        {
            if (i == 0 && transform.position != routes[0].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[0].transform.position, speed);
            }
            if (transform.position == routes[0].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, speed);
            }
            if (transform.position == ports[0].transform.position)
            {
                route = "";
                i = 0;
                port0.firstarrivalhong = 1;
                sail.arrival = 1;
                sail.portarrival = 0;
            }
        }



        if (route == "0-2")
        {
            if (i == 0 && transform.position != routes[1].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[1].transform.position, speed);
            }
            if (transform.position == routes[1].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[2].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[2].transform.position, speed);
            }
            if (transform.position == routes[2].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, speed);
            }
            if (transform.position == ports[2].transform.position)
            {
                i = 0;
                route = "";
                port2.firstarrivaltokyo = 1;
                sail.arrival = 1;
                sail.portarrival = 2;
            }
        }



        if (route == "2-0")
        {
            if (i == 0 && transform.position != routes[2].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[2].transform.position, speed);
            }
            if (transform.position == routes[2].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[1].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[1].transform.position, speed);
            }
            if (transform.position == routes[1].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, speed);
            }
            if (transform.position == ports[0].transform.position)
            {
                i = 0;
                route = "";
                port0.firstarrivalhong = 1;
                sail.arrival = 1;
                sail.portarrival = 0;
            }
        }




        if (route == "0-3")
        {
            if (i == 0 && transform.position != routes[3].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[3].transform.position, speed);
            }
            if (transform.position == routes[3].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, speed);
            }
            if (transform.position == routes[4].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[5].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[5].transform.position, speed);
            }
            if (transform.position == routes[5].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, speed);
            }
            if (transform.position == ports[3].transform.position)
            {
                i = 0;
                route = "";
                port3.firstarrivalsydney = 1;
                sail.arrival = 1;
                sail.portarrival = 3;
            }
        }




        if (route == "3-0")
        {
            if (i == 0 && transform.position != routes[5].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[5].transform.position, speed);
            }
            if (transform.position == routes[5].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[4].transform.position, speed);
            }
            if (transform.position == routes[4].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[3].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[3].transform.position, speed);
            }
            if (transform.position == routes[3].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, speed);
            }
            if (transform.position == ports[0].transform.position)
            {
                i = 0;
                route = "";
                port0.firstarrivalhong = 1;
                sail.arrival = 1;
                sail.portarrival = 0;
            }
        }





        if (route == "1-2")
        {
            if (i == 0 && transform.position != routes[6].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[6].transform.position, speed);
            }
            if (transform.position == routes[6].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[7].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[7].transform.position, speed);
            }
            if (transform.position == routes[7].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, speed);
            }
            if (transform.position == ports[2].transform.position)
            {
                i = 0;
                route = "";
                port2.firstarrivaltokyo = 1;
                sail.arrival = 1;
                sail.portarrival = 2;
            }
        }







        if (route == "2-1")
        {
            if (i == 0 && transform.position != routes[7].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[7].transform.position, speed);
            }
            if (transform.position == routes[7].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[6].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[6].transform.position, speed);
            }
            if (transform.position == routes[6].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (transform.position == ports[1].transform.position)
            {
                i = 0;
                route = "";
                port1.firstarrivalsingapore = 1;
                sail.arrival = 1;
                sail.portarrival = 1;
            }
        }




        if (route == "1-3")
        {
            if (i == 0 && transform.position != routes[8].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[8].transform.position, speed);
            }
            if (transform.position == routes[8].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, speed);
            }
            if (transform.position == routes[9].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[10].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[10].transform.position, speed);
            }
            if (transform.position == routes[10].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, speed);
            }
            if (transform.position == ports[3].transform.position)
            {
                i = 0;
                route = "";
                port3.firstarrivalsydney = 1;
                sail.arrival = 1;
                sail.portarrival = 3;
            }
        }





        if (route == "3-1")
        {
            if (i == 0 && transform.position != routes[10].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[10].transform.position, speed);
            }
            if (transform.position == routes[10].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[9].transform.position, speed);
            }
            if (transform.position == routes[9].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[8].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[8].transform.position, speed);
            }
            if (transform.position == routes[8].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (transform.position == ports[1].transform.position)
            {
                i = 0;
                route = "";
                port1.firstarrivalsingapore = 1;
                sail.arrival = 1;
                sail.portarrival = 1;
            }
        }








        if (route == "2-3")
        {
            if (i == 0 && transform.position != routes[11].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[11].transform.position, speed);
            }
            if (transform.position == routes[11].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[12].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[12].transform.position, speed);
            }
            if (transform.position == routes[12].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[3].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[3].transform.position, speed);
            }
            if (transform.position == ports[3].transform.position)
            {
                i = 0;
                route = "";
                port3.firstarrivalsydney = 1;
                sail.arrival = 1;
                sail.portarrival = 3;
            }
        }







        if (route == "3-2")
        {
            if (i == 0 && transform.position != routes[12].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[12].transform.position, speed);
            }
            if (transform.position == routes[12].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[11].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[11].transform.position, speed);
            }
            if (transform.position == routes[11].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[2].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[2].transform.position, speed);
            }
            if (transform.position == ports[2].transform.position)
            {
                i = 0;
                route = "";
                port2.firstarrivaltokyo = 1;
                sail.arrival = 1;
                sail.portarrival = 2;
            }
        }







        if (route == "4-5")
        {
            if (i == 0 && transform.position != routes[13].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[13].transform.position, speed);
            }
            if (transform.position == routes[13].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[14].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, speed);
            }
            if (transform.position == routes[14].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[15].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[15].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[15].transform.position, speed);
            }
            if (transform.position == routes[15].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (transform.position == ports[5].transform.position)
            {
                i = 0;
                route = "";
                port5.firstarrivalalex = 1;
                sail.arrival = 1;
                sail.portarrival = 5;
            }
        }








        if (route == "5-4")
        {
            if (i == 0 && transform.position != routes[15].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[15].transform.position, speed);
            }
            if (transform.position == routes[15].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[14].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[14].transform.position, speed);
            }
            if (transform.position == routes[14].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[13].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[13].transform.position, speed);
            }
            if (transform.position == routes[13].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (transform.position == ports[4].transform.position)
            {
                i = 0;
                route = "";
                port4.firstarrivalgood = 1;
                sail.arrival = 1;
                sail.portarrival = 4;
            }
        }





        if (route == "4-6")
        {
            if (i == 0 && transform.position != routes[16].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[16].transform.position, speed);
            }
            if (transform.position == routes[16].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (transform.position == ports[6].transform.position)
            {
                route = "";
                i = 0;
                port6.firstarrivalcasa = 1;
                sail.arrival = 1;
                sail.portarrival = 6;
            }
        }




        if (route == "6-4")
        {
            if (i == 0 && transform.position != routes[16].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[16].transform.position, speed);
            }
            if (transform.position == routes[16].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (transform.position == ports[4].transform.position)
            {
                route = "";
                i = 0;
                port4.firstarrivalgood = 1;
                sail.arrival = 1;
                sail.portarrival = 4;
            }
        }








        if (route == "5-6")
        {
            if (i == 0 && transform.position != routes[17].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[17].transform.position, speed);
            }
            if (transform.position == routes[17].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[18].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[18].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[18].transform.position, speed);
            }
            if (transform.position == routes[18].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (transform.position == ports[6].transform.position)
            {
                i = 0;
                route = "";
                port6.firstarrivalcasa = 1;
                sail.arrival = 1;
                sail.portarrival = 6;
            }
        }






        if (route == "6-5")
        {
            if (i == 0 && transform.position != routes[18].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[18].transform.position, speed);
            }
            if (transform.position == routes[18].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[17].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[17].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[17].transform.position, speed);
            }
            if (transform.position == routes[17].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (i == 2 && transform.position != ports[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (transform.position == ports[5].transform.position)
            {
                i = 0;
                route = "";
                port5.firstarrivalalex = 1;
                sail.arrival = 1;
                sail.portarrival = 5;
            }
        }





        if (route == "7-8")
        {
            if (i == 0 && transform.position != routes[19].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[19].transform.position, speed);
            }
            if (transform.position == routes[19].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, speed);
            }
            if (transform.position == ports[8].transform.position)
            {
                route = "";
                i = 0;
                port8.firstarrivalham = 1;
                sail.arrival = 1;
                sail.portarrival = 8;
            }
        }




        if (route == "8-7")
        {
            if (i == 0 && transform.position != routes[19].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[19].transform.position, speed);
            }
            if (transform.position == routes[19].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, speed);
            }
            if (transform.position == ports[7].transform.position)
            {
                route = "";
                i = 0;
                port7.firstarrivallondon = 1;
                sail.arrival = 1;
                sail.portarrival = 7;
            }
        }









        if (route == "7-9")
        {
            if (i == 0 && transform.position != routes[20].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[20].transform.position, speed);
            }
            if (transform.position == routes[20].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[21].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, speed);
            }
            if (transform.position == routes[21].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[22].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[22].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[22].transform.position, speed);
            }
            if (transform.position == routes[22].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (transform.position == ports[9].transform.position)
            {
                i = 0;
                route = "";
                port9.firstarrivalbar = 1;
                sail.arrival = 1;
                sail.portarrival = 9;
            }
        }









        if (route == "9-7")
        {
            if (i == 0 && transform.position != routes[22].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[22].transform.position, speed);
            }
            if (transform.position == routes[22].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[21].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[21].transform.position, speed);
            }
            if (transform.position == routes[21].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[20].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[20].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[20].transform.position, speed);
            }
            if (transform.position == routes[20].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, speed);
            }
            if (transform.position == ports[7].transform.position)
            {
                i = 0;
                route = "";
                port7.firstarrivallondon = 1;
                sail.arrival = 1;
                sail.portarrival = 7;
            }
        }






        if (route == "8-9")
        {
            if (i == 0 && transform.position != routes[23].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[23].transform.position, speed);
            }
            if (transform.position == routes[23].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[24].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, speed);
            }
            if (transform.position == routes[24].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[25].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[25].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[25].transform.position, speed);
            }
            if (transform.position == routes[25].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (transform.position == ports[9].transform.position)
            {
                i = 0;
                route = "";
                port9.firstarrivalbar = 1;
                sail.arrival = 1;
                sail.portarrival = 9;
            }
        }







        if (route == "9-8")
        {
            if (i == 0 && transform.position != routes[25].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[25].transform.position, speed);
            }
            if (transform.position == routes[25].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[24].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[24].transform.position, speed);
            }
            if (transform.position == routes[24].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[23].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[23].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[23].transform.position, speed);
            }
            if (transform.position == routes[23].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[8].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[8].transform.position, speed);
            }
            if (transform.position == ports[8].transform.position)
            {
                i = 0;
                route = "";
                port8.firstarrivalham = 1;
                sail.arrival = 1;
                sail.portarrival = 8;
            }
        }







        if (route == "10-11")
        {
            if (i == 0 && transform.position != routes[26].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[26].transform.position, speed);
            }
            if (transform.position == routes[26].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[27].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, speed);
            }
            if (transform.position == routes[27].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[28].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[28].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[28].transform.position, speed);
            }
            if (transform.position == routes[28].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, speed);
            }
            if (transform.position == ports[11].transform.position)
            {
                i = 0;
                route = "";
                port11.firstarrivalven = 1;
                sail.arrival = 1;
                sail.portarrival = 11;
            }
        }







        if (route == "11-10")
        {
            if (i == 0 && transform.position != routes[28].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[28].transform.position, speed);
            }
            if (transform.position == routes[28].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[27].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[27].transform.position, speed);
            }
            if (transform.position == routes[27].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[26].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[26].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[26].transform.position, speed);
            }
            if (transform.position == routes[26].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (transform.position == ports[10].transform.position)
            {
                i = 0;
                route = "";
                port10.firstarrivalnew = 1;
                sail.arrival = 1;
                sail.portarrival = 10;
            }
        }





        if (route == "10-12")
        {
            if (i == 0 && transform.position != routes[29].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[29].transform.position, speed);
            }
            if (transform.position == routes[29].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[30].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, speed);
            }
            if (transform.position == routes[30].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[31].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[31].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[31].transform.position, speed);
            }
            if (transform.position == routes[31].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, speed);
            }
            if (transform.position == ports[12].transform.position)
            {
                i = 0;
                route = "";
                port12.firstarrivalsan = 1;
                sail.arrival = 1;
                sail.portarrival = 12;
            }
        }








        if (route == "12-10")
        {
            if (i == 0 && transform.position != routes[31].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[31].transform.position, speed);
            }
            if (transform.position == routes[31].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[30].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[30].transform.position, speed);
            }
            if (transform.position == routes[30].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[29].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[29].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[29].transform.position, speed);
            }
            if (transform.position == routes[29].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (transform.position == ports[10].transform.position)
            {
                i = 0;
                route = "";
                port10.firstarrivalnew = 1;
                sail.arrival = 1;
                sail.portarrival = 10;
            }
        }




        if (route == "10-13")
        {
            if (i == 0 && transform.position != routes[32].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[32].transform.position, speed);
            }
            if (transform.position == routes[32].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "";
                i = 0;
                port13.firstarrivalbre = 1;
                sail.arrival = 1;
                sail.portarrival = 13;
            }
        }





        if (route == "13-10")
        {
            if (i == 0 && transform.position != routes[32].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[32].transform.position, speed);
            }
            if (transform.position == routes[32].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (transform.position == ports[10].transform.position)
            {
                route = "";
                i = 0;
                port10.firstarrivalnew = 1;
                sail.arrival = 1;
                sail.portarrival = 10;
            }
        }






        if (route == "11-12")
        {
            if (i == 0 && transform.position != routes[33].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[33].transform.position, speed);
            }
            if (transform.position == routes[33].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, speed);
            }
            if (transform.position == ports[12].transform.position)
            {
                route = "";
                i = 0;
                port12.firstarrivalsan = 1;
                sail.arrival = 1;
                sail.portarrival = 12;
            }
        }






        if (route == "12-11")
        {
            if (i == 0 && transform.position != routes[33].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[33].transform.position, speed);
            }
            if (transform.position == routes[33].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, speed);
            }
            if (transform.position == ports[11].transform.position)
            {
                route = "";
                i = 0;
                port11.firstarrivalven = 1;
                sail.arrival = 1;
                sail.portarrival = 11;
            }
        }







        if (route == "11-13")
        {
            if (i == 0 && transform.position != routes[34].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[34].transform.position, speed);
            }
            if (transform.position == routes[34].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[35].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, speed);
            }
            if (transform.position == routes[35].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[36].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, speed);
            }
            if (transform.position == routes[36].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[37].transform.position, speed);
            }
            if (i == 3 && transform.position != routes[37].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[37].transform.position, speed);
            }
            if (transform.position == routes[37].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (i == 4 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (transform.position == ports[13].transform.position)
            {
                i = 0;
                route = "";
                port13.firstarrivalbre = 1;
                sail.arrival = 1;
                sail.portarrival = 13;
            }
        }










        if (route == "13-11")
        {
            if (i == 0 && transform.position != routes[37].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[37].transform.position, speed);
            }
            if (transform.position == routes[37].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[36].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[36].transform.position, speed);
            }
            if (transform.position == routes[36].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[35].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[35].transform.position, speed);
            }
            if (transform.position == routes[35].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[34].transform.position, speed);
            }
            if (i == 3 && transform.position != routes[34].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[34].transform.position, speed);
            }
            if (transform.position == routes[34].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, speed);
            }
            if (i == 4 && transform.position != ports[11].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[11].transform.position, speed);
            }
            if (transform.position == ports[11].transform.position)
            {
                i = 0;
                route = "";
                port11.firstarrivalven = 1;
                sail.arrival = 1;
                sail.portarrival = 11;
            }
        }











        if (route == "12-13")
        {
            if (i == 0 && transform.position != routes[38].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[38].transform.position, speed);
            }
            if (transform.position == routes[38].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[39].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, speed);
            }
            if (transform.position == routes[39].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[40].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, speed);
            }
            if (transform.position == routes[40].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[41].transform.position, speed);
            }
            if (i == 3 && transform.position != routes[41].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[41].transform.position, speed);
            }
            if (transform.position == routes[41].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (i == 4 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (transform.position == ports[13].transform.position)
            {
                i = 0;
                route = "";
                port13.firstarrivalbre = 1;
                sail.arrival = 1;
                sail.portarrival = 13;
            }
        }








        if (route == "13-12")
        {
            if (i == 0 && transform.position != routes[41].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[41].transform.position, speed);
            }
            if (transform.position == routes[41].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[40].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[40].transform.position, speed);
            }
            if (transform.position == routes[40].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[39].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[39].transform.position, speed);
            }
            if (transform.position == routes[39].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[38].transform.position, speed);
            }
            if (i == 3 && transform.position != routes[38].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[38].transform.position, speed);
            }
            if (transform.position == routes[38].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, speed);
            }
            if (i == 4 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, speed);
            }
            if (transform.position == ports[12].transform.position)
            {
                i = 0;
                route = "";
                port12.firstarrivalsan = 1;
                sail.arrival = 1;
                sail.portarrival = 12;
            }
        }





        if (route == "1-4")
        {
            if (i == 0 && transform.position != routes[42].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[42].transform.position, speed);
            }
            if (transform.position == routes[42].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[43].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[43].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[43].transform.position, speed);
            }
            if (transform.position == routes[43].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[44].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[44].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[44].transform.position, speed);
            }
            if (transform.position == routes[44].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (transform.position == ports[4].transform.position)
            {
                i = 0;
                route = "";
                port4.firstarrivalgood = 1;
                sail.arrival = 1;
                sail.portarrival = 4;
            }
        }





        if (route == "4-1")
        {
            if (i == 0 && transform.position != routes[44].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[44].transform.position, speed);
            }
            if (transform.position == routes[44].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[43].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[43].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[43].transform.position, speed);
            }
            if (transform.position == routes[43].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[42].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[42].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[42].transform.position, speed);
            }
            if (transform.position == routes[42].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (i == 3 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (transform.position == ports[1].transform.position)
            {
                i = 0;
                route = "";
                port1.firstarrivalsingapore = 1;
                sail.arrival = 1;
                sail.portarrival = 1;
            }
        }





        if (route == "1-5")
        {
            if (i == 0 && transform.position != routes[45].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[45].transform.position, speed);
            }
            if (transform.position == routes[45].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[46].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[46].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[46].transform.position, speed);
            }
            if (transform.position == routes[46].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[47].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[47].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[47].transform.position, speed);
            }
            if (transform.position == routes[47].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[48].transform.position, speed);
            }
            if (i == 3 && transform.position != routes[48].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[48].transform.position, speed);
            }
            if (transform.position == routes[48].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (i == 4 && transform.position != ports[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (transform.position == ports[5].transform.position)
            {
                i = 0;
                route = "";
                port5.firstarrivalalex = 1;
                sail.arrival = 1;
                sail.portarrival = 5;
            }
        }




        if (route == "5-1")
        {
            if (i == 0 && transform.position != routes[48].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[48].transform.position, speed);
            }
            if (transform.position == routes[48].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[47].transform.position, speed);
            }
            if (i == 1 && transform.position != routes[47].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[47].transform.position, speed);
            }
            if (transform.position == routes[47].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[46].transform.position, speed);
            }
            if (i == 2 && transform.position != routes[46].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[46].transform.position, speed);
            }
            if (transform.position == routes[46].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, routes[45].transform.position, speed);
            }
            if (i == 3 && transform.position != routes[45].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[45].transform.position, speed);
            }
            if (transform.position == routes[45].transform.position)
            {
                i = 4;
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (i == 4 && transform.position != ports[1].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[1].transform.position, speed);
            }
            if (transform.position == ports[1].transform.position)
            {
                i = 0;
                route = "";
                port1.firstarrivalsingapore = 1;
                sail.arrival = 1;
                sail.portarrival = 1;
            }
        }






        if (route == "0-12")
        {
            if (i == 0 && transform.position != routes[49].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[49].transform.position, 0.009f);
            }
            if (transform.position == routes[49].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, routes[50].transform.position, 0.009f);
            }
            if (i == 1 && transform.position != routes[50].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[50].transform.position, 0.009f);
            }
            if (transform.position == routes[50].transform.position)
            {
                i = 2;
                transform.position = routes[51].transform.position;
            }
            if (i==2 && transform.position == routes[51].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.009f);
            }
            if (i == 3 && transform.position != ports[12].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[12].transform.position, 0.009f);
            }
            if (transform.position == ports[12].transform.position)
            {
                i = 0;
                route = "";
                port12.firstarrivalsan = 1;
                sail.arrival = 1;
                sail.portarrival = 12;
            }
        }


        if (route == "12-0")
        {
            if (i == 0 && transform.position != routes[51].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[51].transform.position, 0.005f);
            }
            if (transform.position == routes[51].transform.position)
            {
                i = 1;
                transform.position = routes[50].transform.position;
            }
            if (i==1 && transform.position == routes[50].transform.position)
            {
                i = 2;
                transform.position = Vector3.MoveTowards(transform.position, routes[49].transform.position, 0.005f);
            }
            if (i == 2 && transform.position != routes[49].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, routes[49].transform.position, 0.005f);
            }
            if (transform.position == routes[49].transform.position)
            {
                i = 3;
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.005f);
            }
            if (i == 3 && transform.position != ports[0].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[0].transform.position, 0.005f);
            }
            if (transform.position == ports[0].transform.position)
            {
                i = 0;
                route = "";
                port0.firstarrivalhong = 1;
                sail.arrival = 1;
                sail.portarrival = 0;
            }
        }





        if (route == "6-9")
        {
            if (i == 0 && transform.position != routes[52].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[52].transform.position, speed);
            }
            if (transform.position == routes[52].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (transform.position == ports[9].transform.position)
            {
                route = "";
                i = 0;
                port9.firstarrivalbar = 1;
                sail.arrival = 1;
                sail.portarrival = 9;
            }
        }





        if (route == "9-6")
        {
            if (i == 0 && transform.position != routes[52].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[52].transform.position, speed);
            }
            if (transform.position == routes[52].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (transform.position == ports[6].transform.position)
            {
                route = "";
                i = 0;
                port6.firstarrivalcasa = 1;
                sail.arrival = 1;
                sail.portarrival = 6;
            }
        }





        if (route == "5-9")
        {
            if (i == 0 && transform.position != routes[53].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[53].transform.position, speed);
            }
            if (transform.position == routes[53].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[9].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[9].transform.position, speed);
            }
            if (transform.position == ports[9].transform.position)
            {
                route = "";
                i = 0;
                port9.firstarrivalbar = 1;
                sail.arrival = 1;
                sail.portarrival = 9;
            }
        }



        if (route == "9-5")
        {
            if (i == 0 && transform.position != routes[53].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[53].transform.position, speed);
            }
            if (transform.position == routes[53].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[5].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[5].transform.position, speed);
            }
            if (transform.position == ports[5].transform.position)
            {
                route = "";
                i = 0;
                port5.firstarrivalalex = 1;
                sail.arrival = 1;
                sail.portarrival = 5;
            }
        }





        if (route == "4-13")
        {
            if (i == 0 && transform.position != routes[54].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[54].transform.position, speed);
            }
            if (transform.position == routes[54].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[13].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[13].transform.position, speed);
            }
            if (transform.position == ports[13].transform.position)
            {
                route = "";
                i = 0;
                port13.firstarrivalbre = 1;
                sail.arrival = 1;
                sail.portarrival = 13;
            }
        }





        if (route == "13-4")
        {
            if (i == 0 && transform.position != routes[54].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[54].transform.position, speed);
            }
            if (transform.position == routes[54].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[4].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[4].transform.position, speed);
            }
            if (transform.position == ports[4].transform.position)
            {
                route = "";
                i = 0;
                port4.firstarrivalgood = 1;
                sail.arrival = 1;
                sail.portarrival = 4;
            }
        }




        if (route == "6-10")
        {
            if (i == 0 && transform.position != routes[55].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[55].transform.position, speed);
            }
            if (transform.position == routes[55].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (transform.position == ports[10].transform.position)
            {
                route = "";
                i = 0;
                port10.firstarrivalnew = 1;
                sail.arrival = 1;
                sail.portarrival = 10;
            }
        }




        if (route == "10-6")
        {
            if (i == 0 && transform.position != routes[55].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[55].transform.position, speed);
            }
            if (transform.position == routes[55].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[6].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[6].transform.position, speed);
            }
            if (transform.position == ports[6].transform.position)
            {
                route = "";
                i = 0;
                port6.firstarrivalcasa = 1;
                sail.arrival = 1;
                sail.portarrival = 6;
            }
        }




        if (route == "7-10")
        {
            if (i == 0 && transform.position != routes[56].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[56].transform.position, speed);
            }
            if (transform.position == routes[56].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[10].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[10].transform.position, speed);
            }
            if (transform.position == ports[10].transform.position)
            {
                route = "";
                i = 0;
                port10.firstarrivalnew = 1;
                sail.arrival = 1;
                sail.portarrival = 10;
            }
        }



        if (route == "10-7")
        {
            if (i == 0 && transform.position != routes[56].transform.position)
            {
                sail.arrival = 0;
                transform.position = Vector3.MoveTowards(transform.position, routes[56].transform.position, speed);
            }
            if (transform.position == routes[56].transform.position)
            {
                i = 1;
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, speed);
            }
            if (i == 1 && transform.position != ports[7].transform.position)
            {
                transform.position = Vector3.MoveTowards(transform.position, ports[7].transform.position, speed);
            }
            if (transform.position == ports[7].transform.position)
            {
                route = "";
                i = 0;
                port7.firstarrivallondon = 1;
                sail.arrival = 1;
                sail.portarrival = 7;
            }
        }










    }
}





