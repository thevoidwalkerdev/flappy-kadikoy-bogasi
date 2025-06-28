using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _hightScoreText;
    private int _score;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        _currentScoreText.text = _score.ToString();
        _hightScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

    }

    private void UpdateHighScore()
    {
        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _hightScoreText.text = _score.ToString();

        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
