using UnityEngine;

public class Interactable : MonoBehaviour
{

    [Header("object Information")]
    [SerializeField] protected string objectName;
    protected GameObject minigame;


    public virtual void Execute(GameObject user)
    {
        print(getName());
        return;
    }

    public string getName()
    {
        return objectName;
    }



}