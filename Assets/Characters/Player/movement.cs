using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D body;
    Animator anim;
    public float runSpeed;

    public bool demage;
    public bool sleep;

    void Start(){
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        Vector2 move = GetComponent<Inputscript>().movement;
        body.velocity = new Vector2(move.x*runSpeed,move.y * runSpeed);

        

        Debug.Log(move);
    }

    void Update()
    {
        Vector2 move = GetComponent<Inputscript>().movement;
        Animations(move);
    }

    void Animations(Vector2 move)
    { 
        if(move.x == 0 && move.y == 0) //idle
        {
            anim.Play("idle");
        }
        else if (demage == true) //demage
        {
            anim.Play("demage");
        }
        else if (sleep == true) //sleep
        {
            anim.Play("sleep");
        }
        else//run
        {
            if(move.x == -1)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if(move.x == 1)
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            anim.Play("run");
        }
    }

}
