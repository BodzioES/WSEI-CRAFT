using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_position : MonoBehaviour
{
    public GameObject[] Player;
    public float offset;

    void Start()
    {
        Player = GameObject.FindGameObjectsWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player[0].transform.position.x, Player[0].transform.position.y,-offset);
    }
}
