using UnityEngine;

public class PlayerCharacter2 : MonoBehaviour
{
    void Start()
    {
        // Calling the singleton instance of the Inventory Manager.
        // InventoryManager.instance.Loadout("default");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // InventoryManager.instance.EquipNextWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            // WeaponManager.Shoot(PlayerManager.instance.Range, PlayerManager.instance.Damage);
        }
    }
}
