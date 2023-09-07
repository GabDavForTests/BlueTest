using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public CellUI itemSlotTemplate;
    public Transform itemSlotContainer;
    private Inventory _inventory;
    private void OnEnable()
    {
        RefreshInventory();
    }
    public void SetInventory(Inventory inv)
    {
        _inventory = inv;
    }
    public void RefreshInventory()
    {
        int x = 0;
        foreach(Transform child in itemSlotContainer)
        {
            x++;
            if (x > 1)
            {
                Destroy(child.gameObject);
                continue;
            }

            child.gameObject.SetActive(false);
        }
        foreach (Item item in _inventory.GetItemList()) 
        {
            CellUI newItemSlot = Instantiate(itemSlotTemplate.gameObject, itemSlotContainer).GetComponent<CellUI>();
            newItemSlot.UpdateCellImage(item.itemIcon, item.itemType);
            newItemSlot.gameObject.SetActive(true);
        }
    }
}
