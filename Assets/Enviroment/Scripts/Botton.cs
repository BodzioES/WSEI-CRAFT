using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botton : MonoBehaviour
{
    public bool Clicked = false;
    [SerializeField] Sprite clicked;
    public event Action click;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            Clicked = true;
            GetComponent<SpriteRenderer>().sprite = clicked;
            click();
        }
    }
}
