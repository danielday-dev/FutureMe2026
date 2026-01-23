using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;
using TMPro;

public class DialogueManagerScript : MonoBehaviour
{
    public static DialogueManagerScript Instance;
    public bool ActiveDialogue = false;
    int CurrentCharacterIndex = 0;
    int SelectedIndex = 0;
    string DisplayText = "";
    bool ChoiceNeeded = false;
    bool Correct = false;

    public Dictionary<int, Choice> Choices = new Dictionary<int, Choice>();
    Choice Choice0 = new Choice
    {
        Options = new Dictionary<string, string>
        {
            {"A", "I pick letter A"},
            {"B", "I pick letter B"},
            {"C", "I pick letter C"}
        },
        CorrectAnswer = "B"
    };
    
    string[] exampleConvo =
    {
        "Greetings.",
        "Pick one of these letters please...-Choice=0",
        "CorrectAnswer=Good choice.",
        "IncorrectAnswer=To each their own I suppose",
        "Thank you for participating."
    };

    void Start()
    {
        Choices[0] = Choice0;
        StartCoroutine(PlayConversationCoroutine(exampleConvo));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator PlayConversationCoroutine(string[] convo)
    {
        ActiveDialogue = true;
        foreach (string Line in convo)
        {   
            string CurrentLine = Line;
            ChoiceNeeded = false;
            int ChoiceIndex = 0;
            //If the line we're showing contains a choice, we only display the line
            //then we take note of which choice it is for later
            if (CurrentLine.Contains("CorrectAnswer=") && !Correct)
            {
                continue;
            }
            else if (CurrentLine.Contains("IncorrectAnswer=") && Correct)
            {
                continue;
            }
            CurrentLine = CurrentLine.Replace("CorrectAnswer=", "");
            CurrentLine = CurrentLine.Replace("IncorrectAnswer=", "");
            if (CurrentLine.Contains("-Choice="))
            {
                ChoiceNeeded = true;
                string[] CurrentLineSplit = CurrentLine.Split("-Choice=");
                CurrentLine = CurrentLineSplit[0];
                ChoiceIndex = int.Parse(CurrentLineSplit[1]);
                Debug.Log($"The choice we need is {CurrentLineSplit[1]}");
            }
            yield return TypewriteDialogue(CurrentLine, "main");
            
            if (ChoiceNeeded)
            {
                DialogueDisplayScript.Instance.ShowLine("", "main");
                Choice ChoiceBeingMade = Choices[ChoiceIndex];
                foreach (KeyValuePair<string, string> option in ChoiceBeingMade.Options)
                {
                    yield return TypewriteDialogue(option.Value, option.Key);
                }
                yield return WaitForChoice();
                string[] ChoiceLetters = {"A", "B", "C"};
                if (ChoiceLetters[SelectedIndex] == ChoiceBeingMade.CorrectAnswer)
                {
                    Correct = true;
                }
            }
        }
        DialogueDisplayScript.Instance.ShowLine("", "main");
        ActiveDialogue = false;
    }

    private IEnumerator WaitForChoice()
    {   
        Color DefaultColour = DialogueDisplayScript.Instance.MainText.color;
        TMP_Text[] ChoiceBoxes =
        {
            DialogueDisplayScript.Instance.ChoiceA,
            DialogueDisplayScript.Instance.ChoiceB,
            DialogueDisplayScript.Instance.ChoiceC    
        };
        SelectedIndex = 0;
        while (true)
        {   
            foreach (TMP_Text Box in ChoiceBoxes)
            {
                Box.color = DefaultColour;
                Box.fontStyle = FontStyles.Normal;
            }
            TMP_Text Selected = ChoiceBoxes[SelectedIndex];
            Selected.fontStyle = FontStyles.Italic;
            Selected.color = Color.white;
            if (Input.GetKeyDown(KeyCode.D))
            {
                SelectedIndex++;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                SelectedIndex--;
            }
            if (SelectedIndex > 2)
            {
                SelectedIndex = 0;
            }
            else if (SelectedIndex < 0)
            {
                SelectedIndex = 2;
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                foreach (TMP_Text Box in ChoiceBoxes)
                {
                    Box.text = "";
                }
                break;
            }
            yield return null;
        }
        
    }

    private IEnumerator ProgressDialogue()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                break;
            }
            yield return null;
        }
    }
    private IEnumerator TypewriteDialogue(string CurrentLine, string TextLocation)
    {
        CurrentCharacterIndex = 0;
        DisplayText = "";
        //Display the line one character at a time, giving the impression of
        //typewriter style dialogue
        while (DisplayText != CurrentLine)
        {
            DisplayText += CurrentLine[CurrentCharacterIndex];
            CurrentCharacterIndex++;
            DialogueDisplayScript.Instance.ShowLine(DisplayText, TextLocation);
            yield return new WaitForSeconds(0.05f);
        }
        if (TextLocation != "main")
        {
            yield return new WaitForSeconds(0.5f);
        }
        else
        {
            yield return ProgressDialogue();
        }
    }
}