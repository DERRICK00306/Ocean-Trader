using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static Dictionary<string, Dictionary<string, int>> price =
        new Dictionary<string, Dictionary<string, int>>()
        {
            {"Tokyo",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",7}, {"Bread",12}, {"Wood",8},{"Beef",14},
                                                    {"Kimono",8}, {"Tea",7}, {"Jewery",33}, {"Spice",5},{"Milk",9},
                                                    {"Wine",16}, {"Fur",19}, {"Chocolate",9}, {"Handcraft",10}
                                                     } },
            {"Hong_Kong",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",8}, {"Bread",12}, {"Wood",8},{"Beef",14},
                                                    {"Kimono",8}, {"Tea",7}, {"Jewery",35}, {"Spice",4},{"Milk",8},
                                                    {"Wine",16}, {"Fur",18}, {"Chocolate",9}, {"Handcraft",10}
                                                     } },
            {"Singapore",new Dictionary<string, int>(){ {"Corn",7}, {"Fish",7}, {"Bread",13}, {"Wood",9},{"Beef",15},
                                                    {"Kimono",9}, {"Tea",7}, {"Jewery",34}, {"Spice",5},{"Milk",8},
                                                    {"Wine",17}, {"Fur",19}, {"Chocolate",10}, {"Handcraft",10}
                                                     } },
            {"Sydney",new Dictionary<string, int>(){ {"Corn",5}, {"Fish",8}, {"Bread",12}, {"Wood",8},{"Beef",14},
                                                    {"Kimono",9}, {"Tea",7}, {"Jewery",33}, {"Spice",4},{"Milk",5},
                                                    {"Wine",17}, {"Fur",18}, {"Chocolate",10}, {"Handcraft",11}
                                                     } },

            {"London",new Dictionary<string, int>(){ {"Corn",7}, {"Fish",7}, {"Bread",10}, {"Wood",9},{"Beef",11},
                                                    {"Kimono",12}, {"Tea",8}, {"Jewery",36}, {"Spice",7},{"Milk",7},
                                                    {"Wine",13}, {"Fur",27}, {"Chocolate",8}, {"Handcraft",14}
                                                     } },
            {"Hamburg",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",8}, {"Bread",10}, {"Wood",8},{"Beef",11},
                                                    {"Kimono",12}, {"Tea",8}, {"Jewery",35}, {"Spice",8},{"Milk",7},
                                                    {"Wine",13}, {"Fur",28}, {"Chocolate",9}, {"Handcraft",15}
                                                     } },
            {"Barcelona",new Dictionary<string, int>(){ {"Corn",5}, {"Fish",8}, {"Bread",9}, {"Wood",8},{"Beef",10},
                                                    {"Kimono",13}, {"Tea",9}, {"Jewery",34}, {"Spice",8},{"Milk",6},
                                                    {"Wine",12}, {"Fur",27}, {"Chocolate",9}, {"Handcraft",15}
                                                     } },

            {"Casablanca",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",10}, {"Bread",12}, {"Wood",5},{"Beef",12},
                                                    {"Kimono",10}, {"Tea",11}, {"Jewery",20}, {"Spice",5},{"Milk",6},
                                                    {"Wine",18}, {"Fur",18}, {"Chocolate",7}, {"Handcraft",11}
                                                     } },
            {"Alexandria",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",11}, {"Bread",12}, {"Wood",5},{"Beef",13},
                                                    {"Kimono",10}, {"Tea",12}, {"Jewery",21}, {"Spice",6},{"Milk",6},
                                                    {"Wine",17}, {"Fur",18}, {"Chocolate",7}, {"Handcraft",11}
                                                     } },
            {"Good_Hope",new Dictionary<string, int>(){ {"Corn",7}, {"Fish",11}, {"Bread",13}, {"Wood",6},{"Beef",13},
                                                    {"Kimono",11}, {"Tea",11}, {"Jewery",22}, {"Spice",5},{"Milk",5},
                                                    {"Wine",18}, {"Fur",19}, {"Chocolate",8}, {"Handcraft",12}
                                                     } },

            {"New_York",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",10}, {"Bread",9}, {"Wood",6},{"Beef",9},
                                                    {"Kimono",13}, {"Tea",10}, {"Jewery",25}, {"Spice",6},{"Milk",4},
                                                    {"Wine",15}, {"Fur",30}, {"Chocolate",7}, {"Handcraft",12}
                                                     } },
            {"San_Francisco",new Dictionary<string, int>(){ {"Corn",6}, {"Fish",10}, {"Bread",9}, {"Wood",7},{"Beef",9},
                                                    {"Kimono",13}, {"Tea",10}, {"Jewery",27}, {"Spice",6},{"Milk",4},
                                                    {"Wine",14}, {"Fur",31}, {"Chocolate",8}, {"Handcraft",13}
                                                     } },
            {"Vancouver",new Dictionary<string, int>(){ {"Corn",5}, {"Fish",11}, {"Bread",10}, {"Wood",7},{"Beef",9},
                                                    {"Kimono",14}, {"Tea",9}, {"Jewery",26}, {"Spice",7},{"Milk",5},
                                                    {"Wine",14}, {"Fur",30}, {"Chocolate",7}, {"Handcraft",12}
                                                     } },
            {"Brenos_Aries",new Dictionary<string, int>(){ {"Corn",7}, {"Fish",10}, {"Bread",10}, {"Wood",7},{"Beef",9},
                                                    {"Kimono",14}, {"Tea",10}, {"Jewery",27}, {"Spice",6},{"Milk",4},
                                                    {"Wine",14}, {"Fur",29}, {"Chocolate",7}, {"Handcraft",13}
                                                     } },
        };

    public static int Money = 999999;

    public static int Carry;

    public static int MaxLoad = 0;

    public static string PreviousScene;

    public static int Cost;

    public static int counttime = 0;

    public static string[] attributes =
        {
            "",
            "Speed",
            "Reputation",
            "Luck",
            "Strength"
        };


    public static string[] ships =
        {
            "Ship1",
            "Ship2",
            "Ship3",
            "Ship4",
            "Ship5",
            "Ship6",
            "Ship7"
        };

    public static Dictionary<string, bool> ShipSelect = new Dictionary<string, bool>()
    {
        {"Ship1", false},
        {"Ship2", false},
        {"Ship3", false},
        {"Ship4", false},
        {"Ship5", false},
        {"Ship6", false},
        {"Ship7", false},
    };

    public static Dictionary<string, bool> ShipStatus = new Dictionary<string, bool>()
    {
        {"Ship1", false},
        {"Ship2", false},
        {"Ship3", false},
        {"Ship4", false},
        {"Ship5", false},
        {"Ship6", false},
        {"Ship7", false},
    };

    

    public static Dictionary<string, int> ShipLoad = new Dictionary<string, int>()
    {
        {"Ship1", 100},
        {"Ship2", 200},
        {"Ship3", 500},
        {"Ship4", 800},
        {"Ship5", 1000},
        {"Ship6", 1500},
        {"Ship7", 3000},
    };

    public static Dictionary<string, int> ShipCost = new Dictionary<string, int>()
    {
        {"Ship1", 300},
        {"Ship2", 400},
        {"Ship3", 600},
        {"Ship4", 1000},
        {"Ship5", 1600},
        {"Ship6", 2400},
        {"Ship7", 4000},
    };

    public static Dictionary<string, int> ShipSpeed = new Dictionary<string, int>()
    {
        {"Ship1", 100},
        {"Ship2", 200},
        {"Ship3", 500},
        {"Ship4", 800},
        {"Ship5", 1000},
        {"Ship6", 1500},
        {"Ship7", 3000},
    };

    public static Dictionary<string, int> GameAttribute = new Dictionary<string, int>()
    {
        {"Speed", 0},
        {"Reputation", 0},
        {"Luck", 0},
        {"Strength", 0}
    };

    public static Dictionary<string, int> Package = new Dictionary<string, int>() {
        {"Corn",0},{"Fish",0},{"Bread",0},{"Beef",0},{"Wood",0},
        {"Tea",0},{"Kimono",0},{"Spice",0},{"Milk",0},{"Hat",0},
        {"Beer",0},{"Wine",0},{"Fur",0},{"Handcraft",0},{"Compass",0},
        {"Chocolate",0},{"Jeans",0},{"Jewery",0},{"Sausage",0}
    };

    public static Dictionary<string, bool> ChinaTown = new Dictionary<string, bool> {
        {"Hong_Kong",false},{"Singapore",false},{"Tokyo",false},{"Sidney",false},{"London",false},
        {"Hamburg",false},{"Barcelona",false},{"Good_Hope",false},{"Alexandria",false},{"Casablanca",false},
        {"New_York",false},{"San_Francisco",false},{"Vencouver",false},{"Brenos_Aries",false}
    };

    
}