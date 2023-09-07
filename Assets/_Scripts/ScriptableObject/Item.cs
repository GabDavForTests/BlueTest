using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Items", order = 1)]

public class Item : ScriptableObject
{
    public ItemList itemType;
    public Sprite itemIcon;
    public Texture2D spriteSheet;
}
public enum ItemList
{
    GoldenArmor,
    SivlerArmor
}