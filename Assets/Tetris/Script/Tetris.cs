using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetris : MonoBehaviour
{
    public Vector2 origin;
    Vector3 position;
    public int left = 1, right = 1, top = 1, down = 1;
    public Sprite[] sprites;
    public int sprite;
    public event Action rotate;
    void Awake()
    {
        origin = transform.position;
        sprite = UnityEngine.Random.Range(0, sprites.Length);
    }
    private void FixedUpdate()
    {
        if (position != transform.position)
        {
            transform.position += position * Time.fixedDeltaTime*24f;
            position -= position * Time.fixedDeltaTime * 24f;
        }else {
            transform.position = new Vector2(Mathf.Floor(transform.position.x+0.5f), Mathf.Floor(transform.position.y+0.5f));
        }
        if(left>4)left = 4;
        if (right>4)right = 4; 
        if(top>4)top = 4;   
        if(down>4)down = 4;
    }
    public void MoveBlock(Vector3 _position)
    {
        position = _position;
    }
    public void rotateTetris()
    {
        transform.Rotate(0, 0, 90);
        transform.position = new Vector2(Mathf.Floor(transform.position.x+0.5f), Mathf.Floor(transform.position.y+0.5f));
        rotate();
    }
    public void backToOrigin()
    {
        transform.position = origin;
    }
    public void explode() { 
        Destroy(gameObject);
    }

}
