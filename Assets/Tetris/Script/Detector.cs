using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public int left, right, top, down;
    [SerializeField]Tetris parent;
    float dist = 0.1f;

    void FixedUpdate()
    {
        RaycastHit2D hit;
        
        if (left==1)  
            if((hit = Physics2D.Raycast(transform.position - transform.right, -transform.right,dist))!=false && hit.collider.gameObject.tag!="Characters")
            {   
                parent.left = 0;
            }
            else
            {
                parent.left += 1;
            }
        
        if (right==1) 
            if((hit = Physics2D.Raycast(transform.position + transform.right, transform.right, dist)) && hit.collider.gameObject.tag != "Characters")
            {
                parent.right = 0;
            }
            else
            {
                parent.right += 1;
            }
        
        if (top == 1) 
            if((hit = Physics2D.Raycast(transform.position + transform.up, transform.up, dist)) && hit.collider.gameObject.tag != "Characters")
            {
                parent.top = 0;
            }
            else
            {
                parent.top += 1;
            }
       
        if (down == 1) 
            if((hit = Physics2D.Raycast(transform.position - transform.up, -transform.up, dist)) && hit.collider.gameObject.tag != "Characters")
            {
                parent.down = 0;
            }
            else
            {
                parent.down += 1;
            }

    }
}
