using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetris : MonoBehaviour
{
    public Vector2 origin;
    Vector3 position;
    public int left = 1, right = 1, top = 1, down = 1;
    GameObject particle;
    void Start()
    {
        origin = transform.position;   
    }
    private void FixedUpdate()
    {
        if (position != transform.position)
        {
            transform.position += position * Time.fixedDeltaTime*24f;
            position -= position * Time.fixedDeltaTime * 24f;
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
    public void backToOrigin()
    {
        transform.position = origin;
    }
    public void explode() { 
        Destroy(gameObject);
    }

}
