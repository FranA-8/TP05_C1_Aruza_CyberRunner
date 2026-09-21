using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioOnClick : MonoBehaviour
{
    [SerializeField] private Button continueButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button backSettingsButton;
    [SerializeField] private Button backCreditsButton;

    [SerializeField] private Button play;
    [SerializeField] private Button settings;
    [SerializeField] private Button credits;
    [SerializeField] private Button exit;

    [SerializeField] private Button exitSettings;

    [SerializeField] private Button exitCredits;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource.GetComponent<AudioSource>();
        continueButton.onClick.AddListener(OnContinueButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        backSettingsButton.onClick.AddListener(OnBackSettingsButtonClicked);
        backCreditsButton.onClick.AddListener(OnBackCreditsButtonClicked);
        play.onClick.AddListener(OnPlayClicked);
        settings.onClick.AddListener(OnSettingsClicked);
        credits.onClick.AddListener(OnCreditsClicked);
        exit.onClick.AddListener(OnExitClicked);
        exitSettings.onClick.AddListener(OnExitSettingsButtonClicked);
        exitCredits.onClick.AddListener(OnExitCreditsButtonClicked);
    }


    private void OnDestroy()
    {
        continueButton.onClick.RemoveListener(OnContinueButtonClicked);
        exitButton.onClick.RemoveListener(OnExitButtonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        creditsButton.onClick.RemoveListener(OnCreditsButtonClicked);
        backSettingsButton.onClick.RemoveListener(OnBackSettingsButtonClicked);
        backCreditsButton.onClick.RemoveListener(OnBackCreditsButtonClicked);
        play.onClick.RemoveListener(OnPlayClicked);
        settings.onClick.RemoveListener(OnSettingsClicked);
        credits.onClick.RemoveListener(OnCreditsClicked);
        exit.onClick.RemoveListener(OnExitClicked);
        exitSettings.onClick.RemoveListener(OnExitButtonClicked);
        exitCredits.onClick.RemoveListener(OnExitButtonClicked);
    }
    private void OnExitCreditsButtonClicked()
    {
       
        
            audioSource.Play();
        
    }

    private void OnExitSettingsButtonClicked()
    {
        audioSource.Play();
    }

    private void OnExitClicked()
    {
        audioSource.Play();
    }

    private void OnCreditsClicked()
    {
        audioSource.Play();
    }

    private void OnSettingsClicked()
    {
        audioSource.Play();
    }

    private void OnPlayClicked()
    {
        audioSource.Play();
    }

    private void OnBackCreditsButtonClicked()
    {
        audioSource.Play();
    }

    private void OnBackSettingsButtonClicked()
    {
        audioSource.Play();
    }

    private void OnCreditsButtonClicked()
    {
        audioSource.Play();
    }

    private void OnSettingsButtonClicked()
    {
        audioSource.Play();
    }

    private void OnExitButtonClicked()
    {
        audioSource.Play();
    }

    private void OnContinueButtonClicked()
    {
        audioSource.Play();

    }

}
