using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    [SerializeField] Botton[] buttons;
    [SerializeField] GameObject target;
    void Start()
    {
        if (buttons != null)
        {
            foreach (Botton button in buttons)
            {
                button.click += Rotate;
            }
        }
    }
    public void Rotate()
    {
        if (target != null)
        {
            target.transform.parent.GetComponent<Tetris>().rotateTetris();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocks")
        {
            target = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blocks")
        {
            target = null;
        }
    }
}
