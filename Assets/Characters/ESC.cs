using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESC : MonoBehaviour
{

    public GameObject Menu;
    bool open = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Menu.transform.localScale = new Vector3(1, 0, 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && open == true) { 
            Menu.transform.localScale = new Vector3(1, 0, 1);
            open = false;
        }else if(Input.GetKeyDown(KeyCode.Escape) && open == false)
        {
            Menu.transform.localScale = new Vector3(1, 1, 1);
            open = true;
        }
    }
}
