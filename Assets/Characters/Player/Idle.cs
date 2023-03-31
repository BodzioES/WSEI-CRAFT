using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    [SerializeField] Animator anim;
    void Start()
    {
        anim.Play("idle");
    }
}
