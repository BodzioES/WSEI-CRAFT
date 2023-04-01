using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position += transform.up * Time.fixedDeltaTime * 10f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
