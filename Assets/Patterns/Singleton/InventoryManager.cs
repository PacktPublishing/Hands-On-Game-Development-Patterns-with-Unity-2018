using UnityEngine;

public class InventoryManager : Singleton<InventoryManager>
{
    public void AddItem(int itemID)
    {
        // Add item into inventory.
        Debug.Log("Adding item to the inventory.");
    }

    public void RemoveItem(int itemID)
    {
        // Remove item from inventory.
        Debug.Log("Removing item to the inventory.");
    }
}