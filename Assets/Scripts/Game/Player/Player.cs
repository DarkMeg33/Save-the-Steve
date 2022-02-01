using UnityEngine;

public class Player : MonoBehaviour
{
    private static Weapon _weaponEquipped;

    public static Weapon WeaponEquipped => _weaponEquipped;

    private void Awake()
    {
        EventSystem.OnWeaponChanged.AddListener(ChangeWeapon);
    }

    private void ChangeWeapon(Weapon weaponChanged)
    {
        _weaponEquipped = weaponChanged;
        Debug.Log(weaponChanged);
    }
}