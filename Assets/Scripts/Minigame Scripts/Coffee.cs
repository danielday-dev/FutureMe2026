using UnityEngine;

public class Coffee : Interactable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameName = "Brew Coffee";
        gameObjective = new string[] { "go to Coffee Machine", "brew Coffee", "Drink Coffee" };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
