using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Canvas _gameOverWindow;

    private Vector3 _spawnPosition = new Vector3(0, 0);

    private void Start()
    {
        _gameOverWindow.worldCamera = FindObjectOfType<Camera>();
        EventSystem.OnGameOver.AddListener(StopGame);
    }

    public void StopGame()
    {
        Debug.Log("Game over");
        Time.timeScale = 0;
        Instantiate(_gameOverWindow, _spawnPosition, Quaternion.identity);
    }
}
