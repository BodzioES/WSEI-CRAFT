using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonExchange : MonoBehaviour
{
    public Sprite newButtonImage;
    public Button button;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeButtonImage()
    {
        button.image.sprite = newButtonImage;
    }
}
