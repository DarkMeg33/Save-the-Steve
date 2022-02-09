using UnityEngine;

public class Creeper : Enemy
{
    [SerializeField] private AudioSource _explosionSound;

    protected override int Points { get; set; } = 32;
    protected override int Damage { get; set; } = 1;

    public override void Remove()
    {
        if (Player.WeaponEquipped.IsBow())
        {
            _deathSound.Play();
            RemoveAt(EventSystem.OnEnemyKilled, Points);
        }
        else if (Player.WeaponEquipped.IsSword())
        {
            _explosionSound.Play();
            RemoveAt(EventSystem.OnEnemyDestroyed, Damage);
        }
    }
}