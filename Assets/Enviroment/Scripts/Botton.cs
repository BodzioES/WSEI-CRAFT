using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botton : MonoBehaviour
{
    public bool Clicked = false;
    public AudioSource audioSource; 
    Sprite baseSprite;
    [SerializeField] Sprite clicked;
    public event Action click;
    [SerializeField] bool onetime;
    [SerializeField] bool trigerSingleTime;
    [SerializeField] bool trigerOne = false;
    private void Awake()
    {
        baseSprite = GetComponent<SpriteRenderer>().sprite;
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(audioSource)audioSource.Play();
        if (!onetime) return;
        if (collision != null)
        {
            Clicked = true;
            GetComponent<SpriteRenderer>().sprite = clicked;
            

            if(click!=null) 
            {
                click(); 
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (onetime) return;
        if (trigerOne && trigerSingleTime) return;
        if (collision != null)
        {
            Clicked = true;
            GetComponent<SpriteRenderer>().sprite = clicked;
            if (click != null) click();
            trigerOne = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (onetime) return;
        if (collision != null)
        {
            Clicked = false;
            GetComponent<SpriteRenderer>().sprite = baseSprite;
            trigerOne = false;

        }
    }
}
