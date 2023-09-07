using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static Action OnInteractButton;
    public static Action OnInventoryButton;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OnInventoryButton?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteractButton?.Invoke();
        }
    }
}
