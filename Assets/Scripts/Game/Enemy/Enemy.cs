using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected Player Player;
    protected abstract int Points { get; set; }
    protected abstract int Damage { get; set; }

    private void Awake()
    {
        var obj = GameObject.FindGameObjectWithTag("MainCamera");
        Player = obj.GetComponent<Player>();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        IncreaseScore();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out DeadLine deadLine))
        {
            Destroy(gameObject);
            ApplyDamage();
        }
    }

    public void ApplyDamage()
    {
        Player.GetDamage(Damage);
    }

    public void IncreaseScore()
    {
        Player.IncreaseScore(Points);
    }
}
