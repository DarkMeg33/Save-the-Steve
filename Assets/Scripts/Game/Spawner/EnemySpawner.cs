using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy[] _enemies;
    
    public void SpawnEnemy(Vector3 spawnPosition)
    {
        int randomEnemy = Random.Range(0, _enemies.Length);
        Instantiate(_enemies[randomEnemy], spawnPosition, Quaternion.identity);
    }
}
