using UnityEngine;
using UnityEngine.UI;

public class UpgradesPanel : MonoBehaviour
{
    [SerializeField] private Button closeMenuButton;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        closeMenuButton.onClick.AddListener(closeMenu);

    //}
//}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeMenu()
    {
        gameObject.SetActive(false);
    }
}
