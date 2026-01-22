using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    [SerializeField] private Button prerequisiteButton;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (prerequisiteButton) { GetComponent<Button>().interactable = false; }

        GetComponent<Button>().onClick.AddListener(upgradeButtonPressed);
    }

    void upgradeButtonPressed()
    {
        Debug.Log("Upgrade Button Pressed");
    }
}
