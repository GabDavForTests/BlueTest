using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public InventoryUI inventoryUI;
    public InventoryUI shopUI;
    public GameObject promptUI;

    private void Awake()
    {
        Player.OnOpenInventory += TriggerInventory;
        Player.OnNpcProximity += TriggerPrompt;
        Shop.OnShopOpen += TriggerShop;
    }
    private void TriggerInventory(Inventory inv)
    {
        inventoryUI.SetInventory(inv);
        inventoryUI.gameObject.SetActive(!inventoryUI.gameObject.activeSelf);
    }
    private void TriggerPrompt(bool trigger)
    {
        promptUI.SetActive(trigger);
        if (!trigger)
        {
            shopUI.gameObject.SetActive(false);
        }
    }
    private void TriggerShop(Inventory shopInv)
    {
        shopUI.SetInventory(shopInv);
        shopUI.gameObject.SetActive(!shopUI.gameObject.activeSelf);
    }
}
