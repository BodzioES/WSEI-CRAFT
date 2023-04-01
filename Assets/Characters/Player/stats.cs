using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    public float thrust;
    public int maxhp;
    public int hp;

    Rigidbody2D rigidbody;
    Animator anim;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {

        if(hp <= 0)
        {
            gameObject.GetComponent<movement>().sleep = true;
            hp = 0;
        }
    }

}
