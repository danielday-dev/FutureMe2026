using UnityEngine;
using UnityEngine.UI;

public class UpgradesPanel : MonoBehaviour
{
    [SerializeField] private Button closeMenuButton;
    [SerializeField] private int numberOfTier1Upgrades = 6;
    [SerializeField] private int numberOfTier2Upgrades = 2;
    [SerializeField] private int numberOfTier3Upgrades = 1;

    [SerializeField] private float tier1Distance = 50;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //    float rotationi = 0;
        //    closeMenuButton.onClick.AddListener(closeMenu);
        //    for (int i = 0; i < numberOfTier1Upgrades; i++)
        //    {
        //        rotationi += (360 / numberOfTier1Upgrades) % 360;
        //        //upgrade here
        //        Vector2 upgradeLocation = new Vector2(transform.position.x, transform.position.y);
        //        upgradeLocation += (new Vector2(Mathf.Sin(rotationi), Mathf.Cos(rotationi))) * tier1Distance;

        //Button button = Instantiate<Button>();/

        //float rotationj = 0;
        //for (int j = 0; j < numberOfTier2Upgrades; j++)
        //{


        //    //upgrade here that links to previous tier

        //    float rotationk = 0;
        //    for (int k = 0; k < numberOfTier3Upgrades; k++)
        //    {
        //        //upgrade here that links to previous tier

        //    }
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
