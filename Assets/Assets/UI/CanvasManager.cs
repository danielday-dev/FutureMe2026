using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private UpgradesPanel upgradesPanel;
    [SerializeField] private SettingsPanel settingsPanel;
    private bool upgradesPanelShowing = false;
    private bool settingsPanelShowing = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (upgradesPanelShowing)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else { Cursor.lockState = CursorLockMode.Locked; } 
            upgradesPanel.gameObject.SetActive(!upgradesPanelShowing);
            //pause game here
            upgradesPanelShowing = !upgradesPanelShowing;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settingsPanel.gameObject.SetActive(!settingsPanelShowing);
            //pause game here
            if(settingsPanelShowing)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else { Cursor.lockState = CursorLockMode.Locked; }
            settingsPanelShowing = !settingsPanelShowing;
        }
        
    }
}
