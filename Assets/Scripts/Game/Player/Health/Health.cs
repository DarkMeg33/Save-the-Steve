using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int _value;

    public int Value => _value;

    private void Awake()
    {
        _value = 10;
        EventSystem.OnEnemyDestroyed.AddListener(GetDamage);
    }

    public void GetDamage(int damage)
    {
        if (damage >= _value)
        {
            EventSystem.SendGameIsOver();
        }

        if (damage == 0)
        {
            return;
        }

        _value -= damage;
        EventSystem.SendHealthChanges(_value);
    }
}
