using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerInventoryUI : InventoryUI
{
    public GameObject equipText;
    private Vector3 equipTransform;
    private void Start()
    {
        equipTransform = equipText.transform.position;
    }
    public override void OnButtonClick(Item item)
    {
        Player.OnEquipItem?.Invoke(item);
        equipText.transform.position = equipTransform;
        equipText.SetActive(true);
        equipText.transform.DOLocalMoveY(equipText.transform.localPosition.y + 20f, .25f).SetEase(Ease.OutSine).OnComplete(()=> { equipText.SetActive(false); });
    }
}
