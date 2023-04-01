using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthControler : MonoBehaviour
{
    public int playerHealth;

    [SerializeField] private Image[] hearts;

    void Start() {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        for(int i=0;i<hearts.Length;i++)
        {
            if(i>-1)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }
}
