using UnityEngine;

public class pickUp : Interactable
{
    [SerializeField] bool pickedUp = false;
    shredPaper activity;

    public override void Execute(GameObject user)
    {
        print(getName());
        pickedUp = true;
        print(pickedUp);
        minigame = GameObject.Find("shredpaper");
        activity = minigame.gameObject.GetComponent<shredPaper>();
        activity.nextObjective();
        print(activity.currentObjective());
        return;
    }

    public string getName()
    {
        return objectName;
    }

}
