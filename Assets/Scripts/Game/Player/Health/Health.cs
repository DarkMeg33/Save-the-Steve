using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private int _value;

    public int Value => _value;

    private void Awake()
    {
        _value = 10;
    }

    public void GetDamage(int damage)
    {
        if (damage >= _value)
        {
            Debug.Log("Game over");
            BroadcastMessage("StopGame");
        }

        if (damage == 0)
        {
            return;
        }

        _value -= damage;
        _healthBar.HealthChange(_value);
    }
}
