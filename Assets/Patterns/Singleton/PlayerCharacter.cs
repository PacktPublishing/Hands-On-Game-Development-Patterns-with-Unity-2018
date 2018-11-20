using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float m_Range = 10.0f;
    public float m_Damage = 12.0f;

    private Weapon m_Weapon;
    private Inventory m_Inventory;

    void Awake()
    {
        m_Weapon = GetComponent<Weapon>();
        m_Inventory = GetComponent<Inventory>();
    }

    void Start ()
    {
        m_Inventory.Loadout("default");
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Inventory.EquipNextWeapon();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            m_Weapon.Shoot(m_Range, m_Damage);
        }
    }
}
