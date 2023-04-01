using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanScript : MonoBehaviour
{
    public GameObject[] players;

    public Transform target;
    public int hp;
    public int demage;

    public float speed;

    Vector2 Old;

    Rigidbody2D rb;
    Animator anim;

    void Awake()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y,0);
        Old = new Vector2(0, 0);
        anim = GetComponent<Animator>();
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update(){

        if(hp <= 0)
        {
            Destroy(gameObject);
        }

        if (players.Length > 1)//Jeœli 2 graczy
        {
            float distance1 = Vector2.Distance(players[0].transform.position, gameObject.transform.position);
            float distance2 = Vector2.Distance(players[1].transform.position, gameObject.transform.position);

            if(distance1 > distance2)
            {
                target = players[1].transform;
            }
            else
            {
                target = players[0].transform;
            }
        }else //Jeœli 1 gracz
        {
            target = players[0].transform;
        }

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if(Old.x > gameObject.transform.position.x) //left
        {
            this.transform.rotation = Quaternion.Euler(0,180,-90);
        }
        else if(Old.x < gameObject.transform.position.x) //right
        {
            this.transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if(Old.y > gameObject.transform.position.y) //down
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if(Old.y < gameObject.transform.position.y) //up
        {
            this.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
        Old = gameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            hp -= other.gameObject.GetComponent<bullet>().demage;
            anim.Play("demage");
            Destroy(other.gameObject);
        }
    }
}
