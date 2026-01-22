using TMPro;
using UnityEngine;

public class DialogueDisplayScript : MonoBehaviour
{
    public static DialogueDisplayScript Instance;

    private TMP_Text dialogueText;

    private void Awake()
    {
        Instance = this;
        dialogueText = GetComponent<TMP_Text>();
    }

    public void ShowLine(string line)
    {
        dialogueText.text = line;
    }
    
}