using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static Dictionary<string, Dictionary<string, int>> price =
        new Dictionary<string, Dictionary<string, int>>()
        {
            {"Tokyo",new Dictionary<string, int>(){ {"Corn",5}, {"Fish",7}, {"Kimono",15}, {"Jewery",40} } },
            {"HK",   new Dictionary<string, int>(){ {"Corn",5}, {"Fish",8}, {"Tea",10}, {"Sausage",14} } },
            {"Singapore",new Dictionary<string, int>(){ {"Corn",5}, {"Fish",8}, {"Spice",5}, {"Jeans",12} } },
            {"Sidney",new Dictionary<string, int>(){ {"Corn",5}, {"Fish",7}, {"Milk",10}, {"Chocolate",18} } },

            {"London",new Dictionary<string, int>(){ {"Corn",6}, {"Bread",7}, {"Hat",12}, {"Compass",26} } },
            {"Hamburg",   new Dictionary<string, int>(){ {"Corn",6}, {"Bread",6}, {"Beer",8}, {"Handcraft",17} } },
            {"Barcelona",new Dictionary<string, int>(){ {"Corn",6}, {"Bread",7}, {"Wine",13}, {"Fur",20} } },

            {"Casablanca",new Dictionary<string, int>(){ {"Corn",7}, {"Wood",9}, {"Fur",15}, {"Wine",16} } },
            {"Alexandria",   new Dictionary<string, int>(){ {"Corn",7}, {"Wood",8}, {"Handcraft",13}, {"Beer",10} } },
            {"GoodHope",new Dictionary<string, int>(){ {"Corn",7}, {"Wood",8}, {"Compass",20}, {"Hat",15} } },

            {"NY",new Dictionary<string, int>(){ {"Corn",5}, {"Beef",11}, {"Chocolate",15}, {"Milk",13} } },
            {"SF",   new Dictionary<string, int>(){ {"Corn",5}, {"Beef",12}, {"Jeans",9}, {"Spice",7} } },
            {"Vencouver",new Dictionary<string, int>(){ {"Corn",5}, {"Beef",11}, {"Jewery",30}, {"Kimono",20} } },
            {"BA",new Dictionary<string, int>(){ {"Corn",5}, {"Beef",12}, {"Sausage",10}, {"Tea",14} } },
        };

    public static int Money = 10000;

    public static Dictionary<string, int> Package = new Dictionary<string, int>() {
        {"Corn",0},{"Fish",0},{"Bread",0},{"Beef",0},{"Wood",0},
        {"Tea",0},{"Kimono",0},{"Spice",0},{"Milk",0},{"Hat",0},
        {"Beer",0},{"Wine",0},{"Fur",0},{"Handcraft",0},{"Compass",0},
        {"Chocolate",0},{"Jeans",0},{"Jewery",0},{"Sausage",0}
    };

    public static Dictionary<string, bool> ChinaTown = new Dictionary<string, bool> {
        {"HK",false},{"Singapore",false},{"Tokyo",false},{"Sidney",false},{"London",false},
        {"Hamburg",false},{"Barcelona",false},{"GoodHope",false},{"Alexandria",false},{"Casablanca",false},
        {"NY",false},{"SF",false},{"Vencouver",false},{"BA",false}
    };

    public static int Carry = 0;
}