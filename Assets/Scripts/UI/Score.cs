using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Spiceship _spiceship;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _spiceship.ScoreChanged += OnScoreChanged;
    }

    private void OnDisable()
    {
        _spiceship.ScoreChanged -= OnScoreChanged;
    }

    private void OnScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}