using TMPro;
using UnityEngine;

public class DialogueDisplayScript : MonoBehaviour
{
    public static DialogueDisplayScript Instance;

    public TMP_Text MainText;
    public TMP_Text ChoiceA;
    public TMP_Text ChoiceB;
    public TMP_Text ChoiceC;

    private TMP_Text TextBox;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowLine(string line, string location)
    {   
        if (location == "main")
        {
            TextBox = MainText;
        }
        if (location == "A")
        {
            TextBox = ChoiceA;
        }
        if (location == "B")
        {
            TextBox = ChoiceB;
        }
        if (location == "C")
        {
            TextBox = ChoiceC;
        }

        TextBox.text = line;
    }
    
}