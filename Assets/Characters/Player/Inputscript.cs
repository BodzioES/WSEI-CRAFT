using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputscript : MonoBehaviour
{
    public string horizontalInput;
    public string veritcalInput;
    //Player 1
    public bool Player1;

    //Player 2
    public bool Player2;

    //Vector
    float horizontal;
    float vertical;
    public Vector2 movement;

    void Update(){
        horizontal = Input.GetAxisRaw(horizontalInput);
        vertical = Input.GetAxisRaw(veritcalInput);

        movement = new Vector2(horizontal, vertical);
    }


}
