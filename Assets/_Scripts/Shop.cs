using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public ShopInventory inv;
    private bool readyToShop = false;
    public static Action<Inventory> OnShopOpen;
    public void CanShop(bool trigger)
    {
        readyToShop = trigger;
    }
    private void Start()
    {
        InputManager.OnInteractButton += OpenShop;
    }

    private void OpenShop()
    {
        if (readyToShop)
        {
            Inventory newInventory = new Inventory();
            newInventory.SetItemList(inv.availableItems);
            OnShopOpen?.Invoke(newInventory);
        }
    }
}
