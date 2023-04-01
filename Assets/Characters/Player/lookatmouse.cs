using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatmouse : MonoBehaviour
{

    void Start()
    {
        // Hides the cursor...
        Cursor.visible = false;
        // Lock the cursor...
        Cursor.lockState = CursorLockMode.Locked;
    }
}
