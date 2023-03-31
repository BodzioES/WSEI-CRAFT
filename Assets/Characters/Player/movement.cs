using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D body;
    Animator anim;
    public float runSpeed;
    public GameObject FireBall;
    public float cooldown;

    Transform hand;

    public bool demage;
    public bool sleep;

    void Start(){
        hand = GameObject.Find("hand").transform;
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        Vector2 move = GetComponent<Inputscript>().movement;
        body.velocity = new Vector2(move.x*runSpeed,move.y * runSpeed);
    }

    void Update()
    {

        //FireBall
        if (Input.GetMouseButtonDown(0) && cooldown <= 0f)
        {
            if(this.transform.localRotation.y == -180f)
            {
                Instantiate(FireBall, hand.position, Quaternion.Euler(0, 180, 0));
            }
            else if (this.transform.localRotation.y == 0f)
            {
                Instantiate(FireBall, hand.position, Quaternion.Euler(0, 0, 0));
            }
            
            cooldown = 0.5f;

        }else if(cooldown >= 0)
        {
            cooldown -= Time.deltaTime;
        }

        Vector2 move = GetComponent<Inputscript>().movement;
        Animations(move);
    }

    void Animations(Vector2 move)
    { 
        if(move.x == 0 && move.y == 0 && demage == false && sleep == false) //idle
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
