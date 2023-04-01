using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    public float thrust;
    public int maxhp;
    public int hp;
    public GameObject hearts;

    Animator anim;

    void Start()
    {
        hearts = GameObject.Find("HealthController");
        
    }
    
    void Update()
    {

        /*if(hp <= 0)
        {
            gameObject.GetComponent<movement>().sleep = true;
            hp = 0;
        }
        else if(hp > 0)
        {
            hearts.GetComponent<HealthControler>().playerHealth = hp;
        }*/
    }

}
