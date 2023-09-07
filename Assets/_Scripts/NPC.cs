using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject chatBubble;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            chatBubble.SetActive(true);
            Player.OnPlayerCloseToNPC?.Invoke();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            chatBubble.SetActive(false);
            Player.OnPlayerLeaveNPC?.Invoke();

        }
    }
}
