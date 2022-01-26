using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Heart[] _hearts;

    private void Start()
    {
        EventSystem.OnHealthChange.AddListener(HealthChange);
    }

    public void HealthChange(int health)
    {
        _hearts[health].ChangeSprite();
    }
}
