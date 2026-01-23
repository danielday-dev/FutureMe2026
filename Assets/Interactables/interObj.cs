using UnityEngine;
using TMPro;
using System.Collections;


public class interObj : Interactable
{
    [SerializeField] string minigameName;
    minigameTemplate activity;
    public TMP_Text textUI;

    public override void Execute(GameObject user)
    {
        minigame = GameObject.Find(minigameName);
        activity = minigame.gameObject.GetComponent<minigameTemplate>();
        //print(activity);
        activity.nextObjective();
        //print(activity.currentObjective());
        displayText();
    }

    public void displayText()
    {
        RectTransform rect = textUI.rectTransform;
        rect.anchoredPosition = new Vector2(0f, 200f);
        textUI.gameObject.SetActive(true);
        textUI.text = activity.currentObjective();
        StartCoroutine(HideAfterDelay());
    }

    IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(3f);
        textUI.gameObject.SetActive(false);
    }
}
