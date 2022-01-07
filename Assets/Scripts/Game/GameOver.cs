using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverWindow;    

    public void StopGame()
    {
        Time.timeScale = 0;
        _gameOverWindow.gameObject.SetActive(true);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }
}
