using UnityEngine;

[RequireComponent(typeof(Spiceship))]
public class SpiceshipShoot : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _shootPoint;

    private Spiceship _spiceShip;

    private void Start()
    {
        _spiceShip = GetComponent<Spiceship>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        var bullet = Instantiate(_bullet, _shootPoint.position, Quaternion.identity);
        bullet.TakeLink(_spiceShip);
    }
}