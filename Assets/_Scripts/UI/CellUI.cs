using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellUI : MonoBehaviour
{
    public Image cellImage;
    public void UpdateCellImage(Sprite sprite)
    {
        cellImage.sprite = sprite;
    }
}
