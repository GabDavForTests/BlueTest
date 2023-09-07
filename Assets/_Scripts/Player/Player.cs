using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Action<bool> OnNpcProximity;
    public static Action<Inventory> OnOpenInventory;
    public Item TestItem;
    private Inventory _inventory;
    private void Awake()
    {
        _inventory = new Inventory();
    }
    private void Start()
    {
        InputManager.OnInventoryButton += OpenInventory;
    }
    private void OpenInventory()
    {
         OnOpenInventory?.Invoke(_inventory);
    }
}
