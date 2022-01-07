using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private Health _health;

    public void GetDamage(int damage)
    {
        _health.GetDamage(damage);
    }

    public void IncreaseScore(int points)
    {
        _score.IncreaseScore(points);
    }
}
