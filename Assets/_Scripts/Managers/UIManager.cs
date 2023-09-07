using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public InventoryUI inventoryUI;
    public GameObject shopUI;
    public GameObject promptUI;

    private void Awake()
    {
        Player.OnOpenInventory += TriggerInventory;
    }
    private void TriggerInventory(Inventory inv)
    {
        inventoryUI.SetInventory(inv);
        inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
    }
}
