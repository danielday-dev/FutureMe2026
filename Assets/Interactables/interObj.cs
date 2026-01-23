using UnityEngine;

public class interObj : Interactable
{
    [SerializeField] string minigameName;
    minigameTemplate activity;

    public override void Execute(GameObject user)
    {
        minigame = GameObject.Find(minigameName);
        activity = minigame.gameObject.GetComponent<minigameTemplate>();
        //Component[] test = minigame.gameObject.GetComponents(typeof(Component));
        //for (int i = 0; i < test.Length; i++)
        //{
        //    Component comp = test[i];
        //    print(comp.GetType());
        //}
        print(activity);
        activity.nextObjective();
        print(activity.currentObjective());

    }
}
