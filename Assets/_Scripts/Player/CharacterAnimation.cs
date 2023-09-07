using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator _anim;
    private Vector2 _previousMovementValue;
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private const string SPEED = "Speed";
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
        if(val.x == 0 && val.y == 0)
        {
            _anim.SetFloat(HORIZONTAL, _previousMovementValue.x);
            _anim.SetFloat(VERTICAL, _previousMovementValue.y);
        }
        else
        {
            _anim.SetFloat(HORIZONTAL, val.x);
            _anim.SetFloat(VERTICAL, val.y);
            _previousMovementValue = val;
        }
        _anim.SetFloat(SPEED, speed);
    }
}
