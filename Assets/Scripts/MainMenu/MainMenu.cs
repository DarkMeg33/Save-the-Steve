using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _settings;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _playMode;

    public void OpenPlayMode()
    {
        _playMode.SetActive(true);
        _panel.SetActive(true);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenSettings()
    {
        _panel.SetActive(true);
        _settings.SetActive(true);
    }
}
