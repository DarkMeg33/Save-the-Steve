using UnityEngine;
using UnityEngine.UI;

public class WeaponChanger : MonoBehaviour
{
    [SerializeField] private Sprite _swordSprite;
    [SerializeField] private Sprite _bowSprite;

    [SerializeField] private Image _weaponImage;

    private Weapon _currentWeapon;

    private void Awake()
    {
        _currentWeapon = GetComponentInChildren<Weapon>();
    }

    public void ChangeWeapon()
    {
        if (_currentWeapon.IsBow())
        {
            _weaponImage.overrideSprite = _swordSprite;

            _currentWeapon.DeleteComponent();
            _currentWeapon = _currentWeapon.gameObject.AddComponent<Sword>();
        }
        else if (_currentWeapon.IsSword())
        {
            _weaponImage.overrideSprite = _bowSprite;

            _currentWeapon.DeleteComponent();
            _currentWeapon = _currentWeapon.gameObject.AddComponent<Bow>();
        }

        EventSystem.SendWeaponChanged(_currentWeapon);
    }
}
