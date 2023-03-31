using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] Botton[] buttons;
    [SerializeField] GameObject particles;
    private void Start()
    {
        if(buttons != null)
        {
            foreach(Botton button in buttons)
            {
                button.click += Check;
            }
        }
    }
    public void Check()
    {
        foreach(Botton button in buttons)
        {
            if (button.Clicked != true) return;
        }
        Open();
    }
    public void Open()
    {
        foreach (Botton button in buttons) button.click -= Check;
        Instantiate(particles, transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
