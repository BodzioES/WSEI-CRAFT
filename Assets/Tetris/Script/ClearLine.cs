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
            if (cheker.check == null)
            {
                all = true;
                break;
            }
        }
        if (all) { return; }
        for (int i = 0; i < chekers.Length; i++)
        {
            if (chekers[i].gameObject != null)
            {
               
            }
        }
        Transform[] parent = new Transform[chekers.Length];
        for (int i = 0; i< chekers.Length; i++)
        {
            bool s = false;
            foreach(var a in parent)
            {
                if (chekers[i].check.transform.parent == a) { s = true; break; }
            }
            if (s)
            {
                continue;
            }
            else {
                parent[i] = chekers[i].check.transform;
            }
        }
        foreach (var cheker in parent)
        {
            if (cheker.transform.parent == null)
                continue;
            cheker.transform.parent.GetComponent<Tetris>().explode();
        }

    }
}
