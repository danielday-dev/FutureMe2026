using UnityEngine;

public class pickUp : Interactable
{
    [SerializeField] bool pickedUp = false;
    [SerializeField] string minigameName;
    minigameTemplate activity;

    public override void Execute(GameObject user)
    {
        print(getName());
        pickedUp = true;
        print(pickedUp);
        if (pickedUp)
        {
            print(minigameName);
            minigame = GameObject.Find(minigameName);
            print(minigame.name);
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
