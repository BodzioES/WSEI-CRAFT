using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLine : MonoBehaviour
{
    [SerializeField] Checker[] chekers;

    private void Update()
    {
        bool all = false;
        foreach (var cheker in chekers)
        {
            if (cheker.check == false)
            {
                all = true;
                break;
            }
        }
        if (all) { return; }
        for(int i = 0; i< chekers.Length; i++)
        {
            chekers[i].GetComponent<Tetris>().explode();
        }

    }
}
