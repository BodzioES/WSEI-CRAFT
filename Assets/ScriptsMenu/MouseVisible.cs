using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVisible : MonoBehaviour
{
    void Start()
    {
        // Hides the cursor...
        Cursor.visible = true;
        // Lock the cursor...
        Cursor.lockState = CursorLockMode.None;
    }
}
