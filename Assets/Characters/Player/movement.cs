using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D body;
    public float runSpeed;

    void Start(){
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        Vector2 move = GetComponent<Inputscript>().movement;
        body.velocity = new Vector2(move.x*runSpeed,move.y * runSpeed);
    }

}
