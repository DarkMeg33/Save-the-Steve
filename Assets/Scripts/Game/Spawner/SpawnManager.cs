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

    private void FixedUpdate()
    {
        StartSpawn();
    }

    public void StartSpawn()
    {
        if (_timeCounter <= 0)
        {
            _timeCounter = _spawnTime;

            int randomSpawner = Random.Range(0, _enemySpawners.Length);
            Vector3 spawnPosition = _enemySpawners[randomSpawner].transform.position;

            _enemySpawners[randomSpawner].SpawnEnemy(spawnPosition);
        }
        else
        {
            _timeCounter -= Time.deltaTime;
        }
    }
}
