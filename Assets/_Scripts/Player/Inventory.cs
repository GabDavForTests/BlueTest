using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> _items;
    public Inventory()
    {
        _items = new();
    }
    public List<Item> GetItemList()
    {
        return _items;
    }
    public void AddItem(Item item)
    {
        _items.Add(item);
    }
}