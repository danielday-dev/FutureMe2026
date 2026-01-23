using UnityEngine;

public class minigameTemplate : MonoBehaviour
{

    [Header("minigame Information")]
    [SerializeField] protected string gameName;
    [SerializeField] protected string[] gameObjective;
    [SerializeField] protected int objectivesCompleted;

    public virtual void Execute(GameObject user)
    {
        return;
    }

    public string getName()
    {
        return gameName;
    }
}
