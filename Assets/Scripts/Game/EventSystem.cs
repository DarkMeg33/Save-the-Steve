using System;
using UnityEngine;
using UnityEngine.Events;

public class EventSystem : MonoBehaviour
{
    public static UnityEvent OnGameOver = new UnityEvent();

    public static void  SendGameOver()
    {
        OnGameOver.Invoke();
    }
}
