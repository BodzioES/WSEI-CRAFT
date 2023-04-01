using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject[] Players;

    public GameObject Player = null;

    int index = 0;

    public void addtindex()
    {
        index++;
    }

    public void delfromindex()
    {
        index--;
    }

    public void SpawnPlayer()
    { 
        Player = Players[index];
    }

    void Start(){
        DontDestroyOnLoad(this);
    }
}
