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

}
