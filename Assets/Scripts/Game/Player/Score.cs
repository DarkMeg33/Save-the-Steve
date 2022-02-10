using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text _highestScoreInscription;
    [SerializeField] private AudioSource _scoreChangedSound;
    [SerializeField] private AudioSource _newRecordSound;

    private int _value;
    private int _highestScore;
    private Text _scoreText;

    private bool _isRecord = false;

    public int Value => _value;

    private void Awake()
    {
        EventSystem.OnEnemyKilled.AddListener(IncreaseScore);
        EventSystem.OnGameOver.AddListener(SetRecord);

        _value = 0;
        _highestScore = PlayerPrefs.GetInt("HighestScore");
        _scoreText = GetComponent<Text>();
    }

    private void IncreaseScore(int points)
    {
        _value += points;
        _scoreText.text = "Score: " + _value;
        _scoreChangedSound.Play();

        if (!_isRecord)
            CheckRecord(_value);
    }

    private void CheckRecord(int score)
    {
        if (score > _highestScore)
        {
            _scoreText.color = Color.yellow;
            _isRecord = true;

            StartCoroutine(Congratulate());
        }
        Debug.Log("Score: " + score);
        Debug.Log("Record: " + _highestScore);
    }

    private void SetRecord()
    {
        PlayerPrefs.SetInt("HighestScore", _value);
    }

    private IEnumerator Congratulate()
    {
       _highestScoreInscription.gameObject.SetActive(true);
       _newRecordSound.Play();

        yield return new WaitForSeconds(5);

        _highestScoreInscription.gameObject.SetActive(false);

        Destroy(_highestScoreInscription);
        StopCoroutine(Congratulate());
    }
}
