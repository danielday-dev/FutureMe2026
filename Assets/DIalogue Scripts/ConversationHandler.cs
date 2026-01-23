using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConversationHandler : MonoBehaviour
{
    public Dictionary<int, Choice> Choices = new Dictionary<int, Choice>();
    public static ConversationHandler Instance;
    public List<string> EmployeeConversation;
    private CoworkerDialogueClass CDClass = new CoworkerDialogueClass();

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Choices[0] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "I pick letter A"},
                {"B", "I pick letter B"},
                {"C", "I pick letter C"}
            },
            CorrectAnswer = "B"
        };
        Choices[1] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "You must be so proud"},
                {"B", "How was the song?"},
                {"C", "What a miserable obligation"}
            },
            CorrectAnswer = "B"
        };
        Choices[2] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "But you're here all day, busy..."},
                {"B", "You need to discuss your responsibilities"},
                {"C", "I'm sure she's right"}
            },
            CorrectAnswer = "A"
        };
        Choices[3] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "Pizza's always nice"},
                {"B", "And they really think that'll work?"},
                {"C", "That could never motivate me"}
            },
            CorrectAnswer = "C"
        };
        Choices[4] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "No"},
                {"B", "I'm married to the grind"},
                {"C", "I've got a cat"}
            },
            CorrectAnswer = "B"
        };
        Choices[5] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "It's good for us to support our community"},
                {"B", "Foul propaganda, no true intent"},
                {"C", "I'm not sure how well it's thought out"}
            },
            CorrectAnswer = "A"
        };
        Choices[6] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "Think I'm still on the H18..."},
                {"B", "I just use a flip phone, honestly"},
                {"C", "I got the H-Phone 21 PRO"}
            },
            CorrectAnswer = "C"
        };
        Choices[7] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "Been to Spain a couple times"},
                {"B", "I have no free time for that"},
                {"C", "Europe? The whole continent? Really?"}
            },
            CorrectAnswer = "B"
        };
        Choices[8] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "Drowning in paperwork, probably"},
                {"B", "Those are waste of time"},
                {"C", "Huh...? What??"}
            },
            CorrectAnswer = "A"
        };
        Choices[9] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "Melancholic ballads do it for me"},
                {"B", "K-Pop"},
                {"C", "Found some new underground indie bands recently"}
            },
            CorrectAnswer = "C"
        };
        Choices[10] = new Choice
        {
            Options = new Dictionary<string, string>
            {
                {"A", "My father was a labourer"},
                {"B", "I'm sure he's proud of you"},
                {"C", "No doubt that shortened his lifespan"}
            },
            CorrectAnswer = "B"
        };
    }

    public void MakeEmployeeConversation()
    {
        string greeting = CDClass.CoworkerGreetings[Random.Range(0, CDClass.CoworkerGreetings.Length)];
        string babble = CDClass.CoworkerBabble[Random.Range(0, CDClass.CoworkerBabble.Length)];
        string nickname = CDClass.Nicknames[Random.Range(0, CDClass.Nicknames.Length)];
        greeting = greeting.Replace("[n]", nickname);
        List<string> KeyList = new List<string>(CDClass.CoworkerQuestions.Keys);
        string[] KeyArray = KeyList.ToArray();
        string Question = KeyArray[Random.Range(0, KeyArray.Length)];
        Answers QuestionAnswers = CDClass.CoworkerQuestions[Question];
        EmployeeConversation.Add(greeting);
        EmployeeConversation.Add(babble);
        EmployeeConversation.Add(Question);
        EmployeeConversation.Add($"CorrectAnswer={QuestionAnswers.GoodAnswer}");
        EmployeeConversation.Add($"IncorrectAnswer={QuestionAnswers.BadAnswer}");
    }
}
