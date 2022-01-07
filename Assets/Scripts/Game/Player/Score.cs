using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int _value;
    private int _highestScore;
    private Text _scoreText;

    public int Value => _value;

    private void Awake()
    {
        _value = 0;
        _highestScore = PlayerPrefs.GetInt("HighestScore");
        _scoreText = GetComponent<Text>();
    }

    public void IncreaseScore(int points)
    {
        _value += points;
        _scoreText.text = _value.ToString();

        if (_value > _highestScore)
        {
            PlayerPrefs.SetInt("HighestScore", _value);
        }
    }
}
