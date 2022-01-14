using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Heart[] _hearts;

    public void HealthChange(int health)
    {
        _hearts[health].ChangeSprite();
    }
}
