using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacmanscript : MonoBehaviour
{

    public GameObject[] players;

    public Transform target;

    public float speed;

    public Rigidbody2D rb;

    Animator anim;

    void OnAwake()
    {
        anim = GetComponent<Animator>();
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update(){

        Vector2 oldVector = gameObject.transform.position;

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
        }else if(players.Length == 1) //Jeœli 1 gracz
        {
            target = players[0].transform;
        }

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        

        if (oldVector.x > transform.position.x) // left
        {
            gameObject.transform.rotation = new Quaternion(0, 0, 90, 0);
        }
        else if (oldVector.x < transform.position.x) // right
        {
            gameObject.transform.rotation = new Quaternion(0, 0, -90, 0);
        }
        else if (oldVector.y > transform.position.y) // down
        {
            gameObject.transform.rotation = new Quaternion(0,0,180,0);
        }
        else if(oldVector.y < transform.position.y) // up
        {
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }
}
