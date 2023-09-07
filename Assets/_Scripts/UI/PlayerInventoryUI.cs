using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventoryUI : InventoryUI
{
    public override void OnButtonClick(Item item)
    {
        Player.OnEquipItem?.Invoke(item);
    }
}
