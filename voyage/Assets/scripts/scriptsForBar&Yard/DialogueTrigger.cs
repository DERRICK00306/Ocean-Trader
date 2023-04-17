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

    private string[] sentencesInformation = {
        "I can't tell you my biggest secret, but it's something that only a few people know.",
        "Some secrets are best kept to oneself, especially if they could hurt others if revealed.",
        "I promised to keep my friend's secret, even though it's been hard to keep it to myself.",
        "Everyone has secrets, but it's up to them whether they want to share them or not.",
        "It's important to trust someone enough to share your secrets with them, but make sure it's someone who won't betray that trust.",
        "The best way to keep a secret is not to tell anyone, but sometimes you need to confide in someone you trust.",
        "I have a secret talent that I don't often share with others, but it's something that brings me joy.",
        "Sometimes secrets can be a burden, especially if you feel like you're carrying them alone.",
        "Secrets can be dangerous, especially if they're used to manipulate or control someone else.",
        "I discovered a secret about someone I know, but I'm not sure whether I should confront them or keep it to myself."
    };

    private string[] sentencesStore =
    {
        "What can I get for you today?",
        "Looking for something specific? Just check if I have it in stock.",
        "Take you time wisely my friend.",
        "These potions may have some special effects",
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

            FindObjectOfType<DialogueManager>().StartRandomDialogue(sentencesInformation);
            FindObjectOfType<DialogueManager>().StartRandomDialogue(UsefulInfo);
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
