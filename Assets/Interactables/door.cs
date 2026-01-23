using UnityEngine;

public class door : Interactable
{
    public doorOpenning doorRef;

    public override void Execute(GameObject user)
    {
        doorRef.opening = !doorRef.opening;
    }
}
