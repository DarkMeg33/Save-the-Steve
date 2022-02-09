using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Enemy : MonoBehaviour
{
    protected abstract int Points { get; set; }
    protected abstract int Damage { get; set; }

    public void OnMouseDown()
    {
        Remove();
    }

    public void Move(Vector2 spawnDirection, float impulseForce)
    {
        GetComponent<Rigidbody2D>().AddForce(spawnDirection * impulseForce, ForceMode2D.Impulse);
    }

    public virtual void Remove()
    {
        if (Player.WeaponEquipped.IsSword())
        {
            RemoveAt(EventSystem.OnEnemyKilled, Points);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out DeadLine deadLine))
        {
            RemoveAt(EventSystem.OnEnemyDestroyed, Damage);
        }
    }

    protected void RemoveAt(UnityEvent<int> action, int param)
    {
        Destroy(gameObject);
        action.Invoke(param);
    }
}