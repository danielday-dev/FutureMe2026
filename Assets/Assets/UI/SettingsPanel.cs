using UnityEngine;
using UnityEngine.UI;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField] private Toggle invertXToggle;
    [SerializeField] private Toggle invertYToggle;
    [SerializeField] private Slider cameraSensitivitySlider;

    [SerializeField] private Slider masterVolumeSlider;
    [SerializeField] private Slider musicVolumeSlider;
    [SerializeField] private Slider effectVolumeSlider;

    [SerializeField] private Button quitButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        initializeSettings();
        quitButton.onClick.AddListener(quitGame);
    }

    void initializeSettings()
    {
        initializeInvertXToggle();
        initializeInvertYToggle();
        initializeCameraSensitivity();
        initializeMasterVolume();
        initializeMusicVolume();
        initializeEffectVolume();

    }

    void initializeInvertXToggle()
    {
        int savedOption = PlayerPrefs.GetInt("invertX", 1);
        invertXToggle.isOn = savedOption == -1;
        invertXToggle.onValueChanged.AddListener(_ => Debug.Log("invertX Updated"));
        invertXToggle.onValueChanged.AddListener(toggled => PlayerPrefs.SetInt("invertX", (toggled ? -1 : 1)));
    }

    void initializeInvertYToggle()
    {
        int savedOption = PlayerPrefs.GetInt("invertY", 1);
        invertYToggle.isOn = savedOption == -1;
        invertYToggle.onValueChanged.AddListener(_ => Debug.Log("invertY Updated"));
        invertYToggle.onValueChanged.AddListener(toggled => PlayerPrefs.SetInt("invertY", (toggled ? -1 : 1)));
    }

    void initializeCameraSensitivity()
    {
        initializeSlider(
            cameraSensitivitySlider,
            "cameraSensitivity",
            0.7f,
            slider => { Debug.Log("cameraSensitivity Updated"); }
            );
    }

    void initializeMasterVolume()
    {
        initializeSlider(
            masterVolumeSlider,
            "masterVolume",
            0.5f,
            slider => { Debug.Log("masterVolume Updated"); }
            );
    }

    void initializeMusicVolume()
    {
        initializeSlider(
            musicVolumeSlider,
            "musicVolume",
            1f,
            slider => { Debug.Log("musicVolume Updated"); }
            );
    }

    void initializeEffectVolume()
    {
        initializeSlider(
            effectVolumeSlider,
            "effectVolume",
            1f,
            slider => { Debug.Log("effectVolume Updated"); }
            );
    }

    void initializeSlider(
        Slider slider,
        string preferenceKey,
        float defaultSliderValue,
        System.Action<Slider> onValueChanged
    )
    {
        float savedOption = PlayerPrefs.GetFloat(preferenceKey, defaultSliderValue);
        slider.value = savedOption;
        onValueChanged(slider);
        slider.onValueChanged.AddListener(_ => onValueChanged(slider));
        slider.onValueChanged.AddListener(index => PlayerPrefs.SetFloat(preferenceKey, index));
    }

    void quitGame()
    {
        Application.Quit();
    }
}