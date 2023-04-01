using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeMap : MonoBehaviour
{
    [SerializeField] Botton button;
    [SerializeField] int id;
    private void Start()
    {
        if (button != null)
        button.click += Change;
    }
    public void Change()
    {
        SceneManager.LoadScene(id);
    }
}
