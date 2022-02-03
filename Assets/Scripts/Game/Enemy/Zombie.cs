using UnityEngine;

public class Zombie : Enemy
{
    protected override int Points { get; set; } = 14;
    protected override int Damage { get; set; } = 1;
}
