using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public ShopInventory inv;
    public static Action<Inventory> OnShopOpen;
    private bool _readyToShop = false;
    public void CanShop(bool trigger)
    {
        _readyToShop = trigger;
    }
    private void Start()
    {
        InputManager.OnInteractButton += OpenShop;
    }

    private void OpenShop()
    {
        if (_readyToShop)
        {
            Inventory newInventory = new Inventory();
            newInventory.SetItemList(inv.availableItems);
            OnShopOpen?.Invoke(newInventory);
        }
    }
}
