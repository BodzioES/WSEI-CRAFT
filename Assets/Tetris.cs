using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetris : MonoBehaviour
{
    Vector3 position;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (position != transform.position)
        {
            rb.velocity = Vector3.zero;
            rb.MovePosition(transform.position + position * Time.fixedDeltaTime*24f);
            position = transform.position;
        }
    }
    public void MoveBlock(Vector2 _position)
    {
        position = _position;
    }
}
