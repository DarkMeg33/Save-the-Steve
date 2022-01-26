using UnityEngine;

public class Creeper : Enemy
{
    protected override int Points { get; set; } = 30;
    protected override int Damage { get; set; } = 2;

    public override void OnMouseDown()
    {
        base.OnMouseDown();
    }
}
