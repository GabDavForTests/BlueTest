using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellUI : MonoBehaviour
{
    public Image cellImage;
    private ItemList id;
    public void UpdateCellImage(Sprite sprite, ItemList newId)
    {
        cellImage.sprite = sprite;
        id = newId;
    }
}
