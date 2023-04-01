using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnPoint : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        Player = GameObject.Find("PlayerSpawn").GetComponent<SpawnPoint>().Player;
        Player = Instantiate(Player, Vector3.zero, Quaternion.identity);
    }

    
}
