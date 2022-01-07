using UnityEngine;

public class Zombie : Enemy
{
    protected override int Points { get; set; } = 10;
    protected override int Damage { get; set; } = 1;
}
