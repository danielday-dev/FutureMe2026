using TMPro;
using UnityEngine;
using System.Collections;

public class pickUp : Interactable
{
    [SerializeField] bool pickedUp = false;
    [SerializeField] string minigameName;
    minigameTemplate activity;
    public TMP_Text textUI;


    public override void Execute(GameObject user)
    {
        pickedUp = true;
        if (pickedUp)
        {
            minigame = GameObject.Find(minigameName);
            activity = minigame.gameObject.GetComponent<minigameTemplate>();
            activity.nextObjective();
            displayText();
        }
        return;
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

    //public string getName()
    //{
    //    return objectName;
    //}

}
