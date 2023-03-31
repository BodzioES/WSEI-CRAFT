using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatmouse : MonoBehaviour
{

    private void Update()
    {
        LookAtMouse2();
    }

    private void LookAtMouse2()
    {
        Vector2 mousePos = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = mousePos - new Vector2(transform.position.x, transform.position.y);
    }
}
