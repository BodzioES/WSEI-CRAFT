using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    int left = 1, right = 1, top = 1, down = 1;
    [SerializeField]Tetris parent;
    Transform parentObject;
    float dist = 0.5f;
    private void Start()
    {
        parentObject = transform.parent;
    }
    void FixedUpdate()
    {
        RaycastHit2D hit;
        
        if (left==1)  
            if((hit = Physics2D.Raycast(transform.position - transform.right, -transform.right,dist))!=false && (hit.collider.gameObject.tag != "Characters" && hit.transform.parent != parentObject))
            {   
            
                parent.left = 0;
            }
            else
            {
                parent.left += 1;
            }
        
        if (right==1) 
            if((hit = Physics2D.Raycast(transform.position + transform.right , transform.right, dist)) && (hit.collider.gameObject.tag != "Characters" && hit.transform.parent != parentObject))
            {
                parent.right = 0;
            }
            else
            {
                parent.right += 1;
            }
        
        if (top == 1) 
            if((hit = Physics2D.Raycast(transform.position + transform.up , transform.up, dist)) && (hit.collider.gameObject.tag != "Characters" && hit.transform.parent != parentObject))
            {
                parent.top = 0;
            }
            else
            {
                parent.top += 1;
            }
       
        if (down == 1) 
            if((hit = Physics2D.Raycast(transform.position - transform.up, -transform.up, dist)) && (hit.collider.gameObject.tag != "Characters" && hit.transform.parent != parentObject))
            {
                parent.down = 0;
            }
            else
            {
                parent.down += 1;
            }

    }
}
