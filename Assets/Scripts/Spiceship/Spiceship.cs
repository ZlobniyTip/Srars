using UnityEngine;
using UnityEngine.Events;

public class Spiceship : MonoBehaviour
{
    [SerializeField] private SpiceshipMover _mover;

    private int _score = 0;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChanged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out KillZone killZone))
        {
            Die();
        }
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChanged?.Invoke(_score);
    }

    public void ResetPlayer()
    {
        _score = 0;
        ScoreChanged?.Invoke(_score);
        _mover.ResetSpiceship();
    }

    public void Die()
    {
        GameOver?.Invoke();
    }
}
