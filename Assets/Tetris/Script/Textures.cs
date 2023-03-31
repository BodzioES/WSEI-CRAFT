using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textures : MonoBehaviour
{
    
    void Start()
    {
        Tetris g = transform.parent.GetComponent<Tetris>();
        GetComponent<SpriteRenderer>().sprite = g.sprites[g.sprite];
    }

}
