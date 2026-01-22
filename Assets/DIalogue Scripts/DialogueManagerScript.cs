using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

public class DialogueManagerScript : MonoBehaviour
{
    public static DialogueManagerScript Instance;
    public bool ActiveDialogue = false;
    int CurrentCharacterIndex = 0;
    string DisplayText = "";
    
    string[] exampleConvo =
    {
        "Greetings.",
        "This is a test, to see if I can make scrolling dialogue",
        "Let's see, shall we...",
        "Making a really long line for the express purpose of testing whether it will automatically take a new line and to figure out what happens if we get just a little bit too long. Big Pingas."
    };
    void Start()
    {
        StartCoroutine(PlayConversationCoroutine(exampleConvo));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator PlayConversationCoroutine(string[] convo)
    {
        ActiveDialogue = true;
        foreach (string CurrentLine in convo)
        {   
            CurrentCharacterIndex = 0;
            DisplayText = "";
            while (DisplayText != CurrentLine)
            {
                DisplayText += CurrentLine[CurrentCharacterIndex];
                CurrentCharacterIndex++;
                DialogueDisplayScript.Instance.ShowLine(DisplayText);
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(2);
        }
        ActiveDialogue = false;
    }
}