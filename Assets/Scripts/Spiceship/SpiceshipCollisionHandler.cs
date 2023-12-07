using UnityEngine;

[RequireComponent(typeof(Spiceship))]
public class SpiceshipCollisionHandler : MonoBehaviour
{
    private Spiceship _spiceship;

    private void Start()
    {
        _spiceship = GetComponent<Spiceship>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
         _spiceship.Die();
    }
}
