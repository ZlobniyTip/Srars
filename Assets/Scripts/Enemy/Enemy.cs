using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyBullet _bullet;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private float _speed;
    [SerializeField] private float _delayBetweenShoot;

    private void Start()
    {
        StartCoroutine(Shoot());
        transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }

    private IEnumerator Shoot()
    {
        var delayBetweenShoot = new WaitForSeconds(_delayBetweenShoot);

        while (true)
        {
            Instantiate(_bullet, _shootPoint.position, Quaternion.identity);

            yield return delayBetweenShoot;
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
