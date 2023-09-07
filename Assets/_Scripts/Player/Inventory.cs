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
    public void SetItemList(List<Item> newItemList)
    {
        _items = new(newItemList);
    }
    public void AddItem(Item item)
    {
        if (_items.Contains(item))
            return; //Unique items only for this test
        _items.Add(item);
    }
    public void RemoveItem(Item item)
    {
        _items.Remove(item);
    }
}
