using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UiSettingsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Button exit;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsMenuPanel;
    [SerializeField] private Slider colorSliderRed;
    [SerializeField] private Slider colorSliderGreen;
    [SerializeField] private Slider colorSliderBlue;
    [SerializeField] private TMP_Text colorNumberRed;
    [SerializeField] private TMP_Text colorNumberGreen;
    [SerializeField] private TMP_Text colorNumberBlue;
    [SerializeField] private Slider volumeMaster;
    [SerializeField] private Slider volumeBackground;
    [SerializeField] private Slider volumeSFX;
    [SerializeField] private Slider volumeUi;
    [SerializeField] private TMP_Text volumeMasterNumber;
    [SerializeField] private TMP_Text volumeBackgroundNumber;
    [SerializeField] private TMP_Text volumeSFXNumber;
    [SerializeField] private TMP_Text volumeUiNumber;
    private SpriteRenderer playerSprite;
    private void Awake()
    {
        playerSprite = GetComponent<SpriteRenderer>();

        exit.onClick.AddListener(OnExitButtonClicked);
        colorSliderRed.onValueChanged.AddListener(OnColorSliderRedP1Changed);
        colorSliderGreen.onValueChanged.AddListener(OnColorSliderGreenP1Changed);
        colorSliderBlue.onValueChanged.AddListener(OnColorSliderBlueP1Changed);
        volumeMaster.onValueChanged.AddListener(OnVolumeMasterChanged);
        volumeBackground.onValueChanged.AddListener(OnVolumeBackgroundChanged);
        volumeSFX.onValueChanged.AddListener(OnVolumeSFXChanged);
        volumeUi.onValueChanged.AddListener(OnVolumeUiChanged);
    }

    private void OnDestroy()
    {
        exit.onClick.RemoveListener(OnExitButtonClicked);
        colorSliderRed.onValueChanged.RemoveListener(OnColorSliderRedP1Changed);
        colorSliderGreen.onValueChanged.RemoveListener(OnColorSliderGreenP1Changed);
        colorSliderBlue.onValueChanged.RemoveListener(OnColorSliderBlueP1Changed);
        volumeMaster.onValueChanged.RemoveListener(OnVolumeMasterChanged);
        volumeBackground.onValueChanged.RemoveListener(OnVolumeBackgroundChanged);
        volumeSFX.onValueChanged.RemoveListener(OnVolumeSFXChanged);
        volumeUi.onValueChanged.RemoveListener(OnVolumeUiChanged);
    }

    private void OnExitButtonClicked()
    {
        settingsMenuPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    private void OnColorSliderRedP1Changed(float value)
    {
        colorNumberRed.text = value.ToString("f0");
        float r = value / 255f;
        float g = colorSliderGreen.value / 255f;
        float b = colorSliderBlue.value / 255f;
        playerSprite.color = new Color(r, g, b, 1f);
    }
    private void OnColorSliderGreenP1Changed(float value)
    {
        colorNumberGreen.text = value.ToString("f0");
        float r = colorSliderRed.value / 255f;
        float g = value / 255f;
        float b = colorSliderBlue.value / 255f;
        playerSprite.color = new Color(r, g, b, 1f);
    }
    private void OnColorSliderBlueP1Changed(float value)
    {
        colorNumberBlue.text = value.ToString("f0");
        float r = colorSliderRed.value / 255f;
        float g = colorSliderGreen.value / 255f;
        float b = value / 255f;
        playerSprite.color = new Color(r, g, b, 1f);
    }
    private void OnVolumeMasterChanged(float value)
    {
        volumeMasterNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeMaster", value);
    }
    private void OnVolumeBackgroundChanged(float value)
    {
        volumeBackgroundNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeBackground", value);
    }
    private void OnVolumeSFXChanged(float value)
    {
        volumeSFXNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeSFX", value);
    }
    private void OnVolumeUiChanged(float value)
    {
        volumeUiNumber.text = value.ToString("f0");
        mixer.SetFloat("VolumeUi", value);
    }



}
