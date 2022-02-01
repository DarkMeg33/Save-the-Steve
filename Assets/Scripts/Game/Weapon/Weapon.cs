using System;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    private void Awake()
    {
        EventSystem.SendWeaponChanged(this);
    }

    public bool IsBow() => TryGetComponent(out Bow bow);
    public bool IsSword() => TryGetComponent(out Sword sword);
    public void DeleteComponent() => Destroy(this);
}
