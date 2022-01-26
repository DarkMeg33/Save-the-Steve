using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private EnemySpawner[] _enemySpawners;
    [SerializeField] private float _spawnTime;

    private float _timeCounter;

    private void Awake()
    {
        _timeCounter = _spawnTime;
    }

    private void Start()
    {
        StartCoroutine(StartSpawn());
    }

    public IEnumerator StartSpawn()
    {
        while (true)
        {
            int randomSpawner = Random.Range(0, _enemySpawners.Length);
            Vector3 spawnPosition = _enemySpawners[randomSpawner].transform.position;

            yield return new WaitForSeconds(_timeCounter);

            _enemySpawners[randomSpawner].SpawnEnemy(spawnPosition);
        }

    }
}
