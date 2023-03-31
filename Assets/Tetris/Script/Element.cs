using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Element : MonoBehaviour
{
    public Tetris parent;
    [SerializeField] GameObject particle;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Blocks") return;
        float x = transform.position.x- collision.transform.position.x;
        float y = transform.position.y - collision.transform.position.y;
        if (Mathf.Abs(x) - Mathf.Abs(y) < 0)
        {
            if (y < 0 && parent.down>3) y = -1;
            else if(y > 0 &&parent.top>3) y = 1;
            else y = 0;

            parent.MoveBlock( new Vector2(0f,Mathf.Floor(y)));
        }
        else
        { 
            if (x < 0 && parent.left>3) x = -1;
            else if(x > 0&& parent.right>3) x = 1;
            else x = 0;
            parent.MoveBlock( new Vector2(Mathf.Floor(x), 0f));
        }
    }
    private void OnDestroy()
    {
        Instantiate(particle,transform.position,transform.rotation);
    }
}
