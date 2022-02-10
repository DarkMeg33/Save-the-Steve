using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private AudioSource _damageApplied;

    private int _value;

    public int Value => _value;

    private void Awake()
    {
        _value = 10;
        EventSystem.OnEnemyDestroyed.AddListener(GetDamage);
    }

    private void GetDamage(int damage)
    {
        if (damage >= _value)
        {
            EventSystem.SendGameIsOver();
        }

        if (damage == 0)
        {
            return;
        }

        for (int i = 0; i < damage; i++)
        {
            _value--;
            PlayDamageAppliedSound();
            EventSystem.SendHealthChanges(_value);

            if (_value == 0) break;
        }
    }

    private void PlayDamageAppliedSound()
    {
        _damageApplied.Play();
    }
}
