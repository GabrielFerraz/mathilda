using UnityEngine;

public class IOIInventory : InteractObjectInteraction
{
    public Inventory _inventory;

    public override void Interact()
    {
        Debug.Log("Inventory");
        _inventory.AddObject(this.gameObject);
    }
}