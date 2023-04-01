using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public static SpawnPlayer Singelton;
    public void Awake()
    {
        Singelton = this;
    }
}
