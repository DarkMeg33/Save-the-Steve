using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Weapon _weapon;
    protected abstract int Points { get; set; }
    protected abstract int Damage { get; set; }

    private void Awake()
    {
        EventSystem.OnWeaponChanged.AddListener(ChangeWeapon);
    }

    public virtual void OnMouseDown()
    {
        Remove();
    }

    private void Remove()
    {
        Destroy(gameObject);
        EventSystem.SendEnemyKilled(Points);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out DeadLine deadLine))
        {
            Destroy(gameObject);
            EventSystem.SendEnemyDestroyed(Damage);
        }
    }

    private void ChangeWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }
}
