using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    public void StartNewGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
