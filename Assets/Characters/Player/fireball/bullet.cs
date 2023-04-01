using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed;
    public int demage;
    public float countdown;

    void Update()
    {
        if(countdown >= 0)
        {
            countdown -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

        gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
