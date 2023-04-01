using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public static Vector3 pos;
    public void Awake()
    {
        pos = transform.position;
        SpawnPoint.player.OnSceneLoad();
    }
}
