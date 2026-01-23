using UnityEngine;

public class pickUp : Interactable
{
    [SerializeField] bool pickedUp = false;
    [SerializeField] string minigameName;
    minigameTemplate activity;

    public override void Execute(GameObject user)
    {
        pickedUp = true;
        if (pickedUp)
        {
            minigame = GameObject.Find(minigameName);
            activity = minigame.gameObject.GetComponent<shredPaper>();
            activity.nextObjective();
            print(activity.currentObjective());
        }
        return;
    }

    public string getName()
    {
        return objectName;
    }

}
