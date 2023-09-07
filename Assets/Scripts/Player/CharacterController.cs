using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 2f;
    public CharacterAnimation characterAnimation;
    private Rigidbody2D _rb;

    private Vector2 _movement;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        if (_rb == null)
        {
            Debug.LogError("No Rigidbody2D found on Player object");
        }
    }
    private void FixedUpdate()
    {
        if(_rb == null)
            return;
        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _movement = _movement.normalized ;
        _rb.MovePosition(_rb.position + _movement * speed * Time.fixedDeltaTime);
        characterAnimation.SetAnimation(new Vector2(_movement.x, _movement.y), _movement.sqrMagnitude);
    }
}
