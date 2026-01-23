using UnityEngine;

public class minigameTemplate : MonoBehaviour
{

    [Header("minigame Information")]
    [SerializeField] protected string gameName;
    [SerializeField] protected string[] gameObjective;
    [SerializeField] protected int objectivesCompleted;

    public void nextObjective()
    {
        objectivesCompleted++;
    }

    public string currentObjective()
    {
        if (objectivesCompleted <= gameObjective.Length)
        {
            return gameObjective[objectivesCompleted];
        }
        else 
        { 
            return "finished"; 
        }
         
    }

    public string getName()
    {
        return gameName;
    }
}
