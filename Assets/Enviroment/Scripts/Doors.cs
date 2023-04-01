using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] Botton[] buttons;
    [SerializeField] GameObject particles;
    GameObject Camera;

    private void Start()
    {
        Camera = GameObject.Find("Main Camera");
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
        Camera.GetComponent<screenshake>().timer = 1f;
        Camera.GetComponent<screenshake>().start = true;
        Camera.GetComponent<screenshake>().ShakeScreen(0.1f,0.1f,0.1f);
        
        foreach (Botton button in buttons) button.click -= Check;
        Instantiate(particles, transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
