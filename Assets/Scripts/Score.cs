using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _bestScore;

    private int _score;

    private void Awake()
    {
        if (instance == null) instance = this;
    }

    private void Start()
    {
        _currentScore.text = _score.ToString();
        _bestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void ScoreUpdate()
    {
        _score++;
        _currentScore.text = _score.ToString();

        if (_score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _bestScore.text = _score.ToString();
        }
    }


}
