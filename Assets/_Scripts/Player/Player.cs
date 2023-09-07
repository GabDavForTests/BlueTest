using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Action<bool> OnNpcProximity;
    public static Action<Inventory> OnOpenInventory;
    public static Action<Item> OnAddItem;
    public static Action<Item> OnEquipItem;
    public List<PlayerArmor> playerArmors = new();
    private Inventory _inventory;
    private void Awake()
    {
        _inventory = new Inventory();
    }

    private void Start()
    {
        InputManager.OnInventoryButton += OpenInventory;
        OnAddItem += AddItemToInventory;
        OnEquipItem += Equip;
    }
    private void OpenInventory()
    {
         OnOpenInventory?.Invoke(_inventory);
    }
    private void AddItemToInventory(Item item)
    {
        _inventory.AddItem(item);
    }
    private void Equip(Item item)
    {
        foreach(Item inventoryItem in _inventory.GetItemList())
        {
            if (inventoryItem.itemType.Equals(item.itemType))
            {
                GetArmor(inventoryItem.itemType).SetActive(true);
            }
            else
            {
                GetArmor(inventoryItem.itemType).SetActive(false);
            }
        }
    }
    private GameObject GetArmor(ItemList id)
    {
        foreach(PlayerArmor ar in playerArmors)
        {
            if (ar.id == id)
                return ar.armor;
        }
        return null;
    }
}
[Serializable]
public struct PlayerArmor
{
    public ItemList id;
    public GameObject armor;
}