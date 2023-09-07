using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject chatBubble;
    private Shop shop;
    private void Awake()
    {
        shop = GetComponent<Shop>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TriggerChatBubble(true);
            Player.OnNpcProximity?.Invoke(true);
            SetShop(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TriggerChatBubble(false);
            Player.OnNpcProximity?.Invoke(false);
            SetShop(false);
        }
    }
    private void TriggerChatBubble(bool trigger)
    {
        if (chatBubble == null)
            return;
        chatBubble.SetActive(trigger);
    }
    private void SetShop(bool trigger)
    {
        if (shop == null)
            return;
        shop.CanShop(trigger);
    }
}
