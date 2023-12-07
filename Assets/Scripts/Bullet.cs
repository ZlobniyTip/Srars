using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Spiceship _spiceship;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            _spiceship.IncreaseScore();
            enemy.Die();
            Destroy(gameObject);
        }
    }

    public void TakeLink(Spiceship spiceship)
    {
        _spiceship = spiceship;
    }
}
