using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Element : MonoBehaviour
{
    Vector2 current;
    Tetris parent;
    private void Start()
    {
        current = parent.transform.position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float x = transform.position.x- collision.transform.position.x;
        float y = transform.position.y - collision.transform.position.y;
        if (Mathf.Abs(x) - Mathf.Abs(y) < 0)
        {
            parent.MoveBlock(current + new Vector2(0f,Mathf.Floor(y)));
        }
        else
        {
            parent.MoveBlock(current + new Vector2(Mathf.Floor(x), 0f));
        }
    }
}
