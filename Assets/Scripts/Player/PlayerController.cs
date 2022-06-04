using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] float _speed = 5;

    void Start()
    {
        PlayerSetUp();
    }

    void FixedUpdate()
    {
        PlayerInput();
    }

    void PlayerSetUp()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void PlayerInput()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector2 vec = new Vector2(h, v);
        _rb.velocity = vec.normalized * _speed;
    }
}
