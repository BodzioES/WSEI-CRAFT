using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum type{ wide, sniper, around}
public class TurretWideBehaviour : MonoBehaviour
{
    [SerializeField] float Cooldown;
    float current;
    [SerializeField] type type;
    public float bullets = 1;
    [SerializeField] GameObject bullet;
    float deg;
    void Awake()
    {
        current = Cooldown;
        
    }
    private void Update()
    {
        current -= Time.deltaTime;
        if (type == type.wide) {
            
            if (current < 0) {

                current = Cooldown;
                    Shoot();
                } 
        }
        if (type == type.around)
        {
            deg = 360 / bullets;
            if (current < 0)
            {
                current = Cooldown;
                transform.Rotate(0, 0, deg);
                Vector3 diff = transform.position - transform.position + transform.up;
                diff.Normalize();
                float rot_z = Mathf.Atan2(-diff.y, -diff.x) * Mathf.Rad2Deg;
                Quaternion a = Quaternion.Euler(0f, 0f, rot_z - 90);
                Instantiate(bullet, transform.position + transform.up, a);
                transform.Rotate(0, 0, +deg);
            }

        }
    }

    private void Shoot()
    {
            deg = 90 / bullets+1;
            for(int i = 0; i < bullets; i++)
            {
                Vector3 diff = transform.position - transform.position + transform.up;
                diff.Normalize();
                float rot_z = Mathf.Atan2(-diff.y, -diff.x) * Mathf.Rad2Deg;
                Quaternion a = Quaternion.Euler(0f, 0f, rot_z - 90);
                Instantiate(bullet, transform.position + transform.up,a);
                transform.Rotate(0, 0, -deg);
            }
            transform.rotation = Quaternion.Euler(0, 0, -90);
        
       
       
    } 

}
