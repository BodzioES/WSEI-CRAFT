using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithParticles : MonoBehaviour
{
    public ParticleSystem sys;
    public float duration;
    void Start()
    {
        Destroy(gameObject, 2f);
    }
}
