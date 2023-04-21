using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Numerics;
using Unity.Mathematics;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor;
using UnityEngine;
using static Unity.VisualScripting.Member;
//using static UnityEditor.FilePathAttribute;

public class DialogueTrigger : MonoBehaviour
{


    private string[] UsefulInfo =
    {
        "Americans and Africans pay a premium for their FISH compared to other regions.",
        "BREAD prices in Europe and Asia tend to be higher than elsewhere in the world.",
        "The cost of WOOD is notably lower in Africa and America compared to other places.",
        "American BEEF can be quite cheap compared to BEEF in other parts of the globe.",
        "KIMONO is generally more cheaper in Asia than in other regions.",
        "You may notice that TEA is significantly more expensive in America and Africa than in other areas.",
        "The price of JEWERY is notably inflated in Europe and Asia when compared to other locations.",
        "Europeans and Americans have to pay a premium for their SPICE when compared to other regions.",
        "The cost of MILK in America is often much lower than in other parts of the world.",
        "European consumers typically have to shell out less for their WINES than those in other areas.",
        "FUR prices in Europe and America can be quite exorbitant compared to other parts of the globe.",
        "It's no secret that CHOCOLATE is often more costly in Asia than in other regions.",
        "The price of HANDCRAFT in Asia tends to be lower than in other places around the world.",
    };




    public Dialogue dialogue;
    //public Dialogue information;
    
    private string[] sentencesChat = {
        "Good evening, do you have a reservation?",
        "Hi there, are you dining in or taking out?",
        "Hello and welcome, would you like to see our menu?",
        "Greetings, can I get you started with some drinks?",
        "Welcome back, would you like to order your usual?",
        "Hi, have you dined with us before?",
        "Hello, are you celebrating a special occasion today?",
        "Welcome, do you have any dietary restrictions we should be aware of?",
        "Welcome to our pub! You guys don't look like locals.\nYou MUST try some of our famous drinks!",
        "I have some useful information. Of course, not for free."
    };

    private string[] sentencesInformation =
    {
        "You are unlucky my friend, there's nothing useful that I can tell at this moment. Try again when you feel yourself lucky!"
    };

    private string[] sentencesStore =
    {
        "What can I get for you today?",
        "Looking for something specific? Just check if I have it in stock.",
        "Take you time wisely my friend.",
        "Higher speed will make you journey faster!",
        "If you have high reputation among this area, I'm sure the locals will give you some discount for trade.",
        "If you need a bit of luck, don't wait to drink the purple one!",
        "The red wine will make your sailors more energetic, your travel cost will be reduced.",
        "They are my masterpieces",
        "My goods are the best!"
    };

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    
    public void TriggerDialogueRandom()
    {
        FindObjectOfType<DialogueManager>().StartRandomDialogue(sentencesChat);
    }

    public void TriggerInformationRandom()
    {
        if (Global.Money >= 10)
        {
            Global.Money -= 10;

            System.Random rand = new System.Random();

            int index = rand.Next(1000);

            if (Global.GameAttribute["Luck"] < index) FindObjectOfType<DialogueManager>().StartRandomDialogue(sentencesInformation);
            else FindObjectOfType<DialogueManager>().StartRandomDialogue(UsefulInfo);
        }
        else
        {
            FindObjectOfType<DialogueManager>().MoneyInsufficient();
        }
        
    }

    public void TriggerStoreRandom()
    {
        FindObjectOfType<DialogueManager>().StartRandomStore(sentencesStore);
    }
}
