using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D body;
    public Animator anim;

    public float runSpeed;
    public GameObject FireBall;
    public float cooldown;

    Transform hand;

    public bool demage;
    public bool sleep;

    private float timer_demage;

    void Start(){
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
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
            Instantiate(FireBall, hand.position, transform.rotation);
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
        if (move.x == 0 && move.y == 0 && sleep == false && demage == false) //idle
        {
            anim.Play("idle");
        }else if(demage == true)
        {
            if(timer_demage > 0)
            {
                timer_demage -= Time.deltaTime;
            }
            else
            {
                demage = false;
            }
        }
        else if (sleep == true) //sleep
        {
            anim.Play("sleep");
        }
        else //run
        {
            if (move.x == -1)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (move.x == 1)
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            anim.Play("run");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pacman" || other.gameObject.tag == "Enemy")
        {
            GetComponent<stats>().hp -= other.gameObject.GetComponent<PacmanScript>().demage;

            if(sleep == false)
            {
                demage = true;
                anim.Play("demage");
                timer_demage = 0.2f;

                Camera.main.GetComponent<screenshake>().timer = 1f;
                Camera.main.GetComponent<screenshake>().start = true;
                Camera.main.GetComponent<screenshake>().ShakeScreen(0.1f, 0.1f, 0.1f);
                
            }
            
            transform.position += (transform.position - other.gameObject.transform.position);
            
        }else if(other.gameObject.tag == "Wall")
        {
            //transform.position = (transform.position - other.gameObject.transform.position);
        }
    }
}
