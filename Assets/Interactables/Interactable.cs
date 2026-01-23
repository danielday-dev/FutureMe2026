using UnityEngine;

public class Interactable : MonoBehaviour
{

    [SerializeField] string activity = "Example";
    public virtual void Execute(GameObject user)
    {
        return;
    }

    public string getActivity()
    {
        return activity;
    }
}