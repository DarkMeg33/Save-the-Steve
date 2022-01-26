using System;
using UnityEngine;
using UnityEngine.Events;

public class EventSystem : MonoBehaviour
{
    public static UnityEvent OnGameOver = new UnityEvent();
    public static UnityEvent<int> OnHealthChange = new UnityEvent<int>();
    public static UnityEvent<int> OnEnemyKilled = new UnityEvent<int>();
    public static UnityEvent<int> OnEnemyDestroyed = new UnityEvent<int>();
    public static UnityEvent<Weapon> OnWeaponChanged = new UnityEvent<Weapon>();

    public static void SendGameIsOver()
    {
        OnGameOver.Invoke();
    }

    public static void SendHealthChanges(int healthRemaining)
    {
        OnHealthChange.Invoke(healthRemaining);
    }

    public static void SendEnemyKilled(int points)
    {
        OnEnemyKilled.Invoke(points);
    }

    public static void SendEnemyDestroyed(int damage)
    {
        OnEnemyDestroyed.Invoke(damage);
    }

    public static void SendWeaponChanged(Weapon weapon)
    {
        OnWeaponChanged.Invoke(weapon);
    }
}
