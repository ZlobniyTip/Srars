using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] private Enemy _prefab;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var delayBetweenSpawn = new WaitForSeconds(_secondsBetweenSpawn);

        while(true)
        {
            float randomPosY = Random.Range(_minSpawnPositionY,_maxSpawnPositionY);
            Instantiate(_prefab, new Vector3(transform.position.x, randomPosY), Quaternion.identity);

            yield return delayBetweenSpawn;
        }
    }
}
