using UnityEngine;

public class Meeting : Interactable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameName = "Go To Meeting";
        gameObjective = new string[] { "Go to the meeting room", "Try not to fall asleep" };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
