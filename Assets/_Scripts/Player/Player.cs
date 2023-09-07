using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Action OnPlayerCloseToNPC;
    public static Action OnPlayerLeaveNPC;
    public static Action<Inventory> OnOpenInventory;
    public Item TestItem;
    private Inventory _inventory;
    private void Awake()
    {
        _inventory = new Inventory();
        _inventory.AddItem(TestItem);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            OnOpenInventory?.Invoke(_inventory);

        }
    }
}
