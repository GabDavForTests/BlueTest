using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ShopInventory", menuName = "ScriptableObjects/Shop", order = 2)]
public class ShopInventory : ScriptableObject
{
    public List<Item> availableItems = new();
}
