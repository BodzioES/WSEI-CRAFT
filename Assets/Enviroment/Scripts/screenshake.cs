using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenshake : MonoBehaviour
{
    GameObject Main;

    public float shake;
    public bool start = false;
    public float shakeAmount;
    public float decreaseFactor;
    public float timer;
    public GameObject Player;

    void Start()
    {
        Main = GameObject.Find("Main Camera");
    }

    void Update()
    {

        if(timer > 0)
        {
            timer -= Time.deltaTime;
            ShakeScreen(0.1f, 0.1f, 0.1f);
        }
        else
        {
            start = false;
            timer = 0;
        }
        //ShakeScreen(shake, decreaseFactor, shakeAmount); Deklaracja
    }

    public void ShakeScreen(float shake,float Factor,float Amount)
    {

            decreaseFactor = Factor;
            shakeAmount = Amount;

            if (shake > 0f)
            {
               
                Main.transform.localPosition = (Random.insideUnitSphere * shakeAmount + transform.localPosition);
                shake -= Time.deltaTime * decreaseFactor;
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
            else
            {
                shake = 0.0f;
            }
        
    }
}
