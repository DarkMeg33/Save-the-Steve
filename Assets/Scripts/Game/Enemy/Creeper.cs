using UnityEngine;

public class Creeper : Enemy
{
    protected override int Points { get; set; } = 30;
    protected override int Damage { get; set; } = 2;

    protected override void Remove()
    {
        if (Player.WeaponEquipped.IsBow())
        {
            Destroy(gameObject);
            EventSystem.SendEnemyKilled(Points);
        }
    }
}