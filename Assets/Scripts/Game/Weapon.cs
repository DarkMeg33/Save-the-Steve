using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public void OnMouseDown()
    {
        ChangeWeapon();
    }

    public void ChangeWeapon()
    {
        if (TryGetComponent(out Bow bow))
        {
            EventSystem.SendWeaponChanged(gameObject.AddComponent<Sword>());
            Destroy(this);
        }
        else
        {
            EventSystem.SendWeaponChanged(gameObject.AddComponent<Bow>());
            Destroy(this);
        }
        
    }
}
