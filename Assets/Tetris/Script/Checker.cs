using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public GameObject check ; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered!");
        if (collision.gameObject.tag == "Blocks")
        {
            check = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocks")
        {
            check = null;
        }
    }
}

