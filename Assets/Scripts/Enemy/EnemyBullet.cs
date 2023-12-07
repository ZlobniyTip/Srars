using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }

    private void Update()
    {
        transform.Translate(-Vector2.up * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Spiceship player))
        {
            player.Die();
        }
    }
}
