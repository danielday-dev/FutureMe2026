using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    enum UpgradeEffect
    {
        IncreaseCoffee,
    }
    
    [SerializeField] private Button prerequisiteButton;
    [SerializeField] private gameManager gameManager;
    [SerializeField] private UpgradeEffect effect;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (prerequisiteButton) { GetComponent<Button>().interactable = false; }

        GetComponent<Button>().onClick.AddListener(upgradeButtonPressed);
        prerequisiteButton.onClick.AddListener(prerequisiteButtonPressed);
    }

    void upgradeButtonPressed()
    {
        Debug.Log("Upgrade Button Pressed");

        //check if you have an upgrade point
        if (gameManager.upgradePoints > 0)
        {
            GetComponent<Button>().interactable = false;
            activateUpgrade();
            gameManager.upgradePoints--;
        }
    }

    void activateUpgrade()
    {
        switch (effect)
        {
            case UpgradeEffect.IncreaseCoffee:
                {
                    
                }
                break;
            default:
                { Debug.Log("defaultID from button pressed, this shouldnt happen"); }break;
        }
    }

    void prerequisiteButtonPressed()
    {
        GetComponent<Button>().interactable = true;
    }
}
