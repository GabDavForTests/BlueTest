using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        if (_anim == null)
        {
            Debug.LogError("No Animator found on Player object");
        }
    }
    public void SetAnimation(Vector2 val, float speed)
    {
        if (_anim == null)
            return;
        _anim.SetFloat("Horizontal", val.x);
        _anim.SetFloat("Vertical", val.y);
        _anim.SetFloat("Speed", speed);
    }
}
