using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInventoryUI : InventoryUI
{
    public override void OnButtonClick(Item item)
    {
        Player.OnAddItem?.Invoke(item);
        _inventory.RemoveItem(item);
        RefreshInventory();
    }
}
