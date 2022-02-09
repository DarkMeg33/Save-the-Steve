using UnityEngine;

public class Creeper : Enemy
{
    protected override int Points { get; set; } = 32;
    protected override int Damage { get; set; } = 1;

    public override void Remove()
    {
        if (Player.WeaponEquipped.IsBow())
        {
            RemoveAt(EventSystem.OnEnemyKilled, Points);
        }
        else if (Player.WeaponEquipped.IsSword())
        {
            RemoveAt(EventSystem.OnEnemyDestroyed, Damage);
        }
    }
}