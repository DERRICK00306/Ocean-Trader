using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DialogueManager : MonoBehaviour
{

    public GameObject interactButton;
    public GameObject returnButton;
    public GameObject dialoguePanel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI storeText;


    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    /*public void StartDialogue(Dialogue dialogue)
    {

        //Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }*/

    public void MoneyInsuffient()
    {
        dialogueText.text = "It seems that you don't have enough money my friend.";
    }


    public void StartRandomDialogue(string[] sentences)
    {
        System.Random rand = new System.Random();
        int prevIndex = -1; // initialize previous index to -1
        int index;
        do
        {
            index = rand.Next(sentences.Length);
        } while (index == prevIndex); // repeat until a different index is generated

        dialogueText.text = sentences[index];

        prevIndex = index; // update previous index

    }

    public void StartRandomStore(string[] sentences)
    {
        System.Random rand = new System.Random();
        int prevIndex = -1; // initialize previous index to -1
        int index;
        do
        {
            index = rand.Next(sentences.Length);
        } while (index == prevIndex); // repeat until a different index is generated

        storeText.text = sentences[index];

        prevIndex = index; // update previous index
    }

    /*public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        //Debug.Log(sentence); 
    }*/

    public void EndDialogue()
    {
        //Debug.Log("End of Conversation.");
        dialoguePanel.SetActive(false);
        interactButton.SetActive(true);
        returnButton.SetActive(true);

    }
}
