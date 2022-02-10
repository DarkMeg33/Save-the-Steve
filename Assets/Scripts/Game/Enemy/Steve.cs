using UnityEngine;

public class Steve : Enemy
{
    protected override int Points { get; set; } = 17;
    protected override int Damage { get; set; } = 1;

    public override void Remove()
    {
        SoundManager.OnSteveKilled.Invoke();
        RemoveAt(EventSystem.OnEnemyDestroyed, Damage);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out DeadLine deadLine))
        {
            RemoveAt(EventSystem.OnEnemyKilled, Points);
        }
    }
}
