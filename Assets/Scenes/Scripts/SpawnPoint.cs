using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{

    public GameObject[] Players;

    public GameObject Player = null;

    int index = 0;
    public static SpawnPoint player;
    private void Awake()
    {
        player = this;
    }
    public void addtindex()
    {
        index++;
    }

    public void delfromindex()
    {
        index--;
    }

    void Start(){
        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        Player = Players[index];
    }
    public void OnSceneLoad()
    {
        
            Instantiate(Player,SpawnPlayer.pos,Quaternion.identity);
            Destroy(gameObject);
    }
}
