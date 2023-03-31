using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    int check = 0; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bricks")
        {
            check = 1;
        }
        else
        {
            check = 0;
        }
    }
}

