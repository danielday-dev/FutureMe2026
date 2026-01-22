using UnityEngine;

public class shredPaper : Interactable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameName = "Shred Papers";
        gameObjective = new string[] { "Pick up Papers", "go to Shredder" };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
