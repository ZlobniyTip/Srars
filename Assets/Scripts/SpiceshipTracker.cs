using UnityEngine;

public class SpiceshipTracker : MonoBehaviour
{
    [SerializeField] private Spiceship _spiceship;
    [SerializeField] private float _xOffSet;

    private void Update()
    {
        transform.position = new Vector3(_spiceship.transform.position.x - _xOffSet, transform.position.y, transform.position.z);
    }
}
