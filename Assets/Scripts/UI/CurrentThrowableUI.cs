using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentThrowableUI : MonoBehaviour
{
    [Header("References")]
    public Image frame;
    public Sprite emptyFrame, redFrame, greenFrame, blueFrame, yellowFrame;
    public ThrowingBehaviour throwingBehaviour;

    private void Awake()
    {
        frame.sprite = emptyFrame;
    }

    private void Update()
    {
        switch(throwingBehaviour.colorPickUp)
        {
            case 0:
                frame.sprite = redFrame;
                break;
            case 1:
                frame.sprite = blueFrame;
                break;
            case 2:
                frame.sprite = greenFrame;
                break;
            case 3: 
                frame.sprite = yellowFrame;
                break;
            case -1:
                frame.sprite = emptyFrame;
                break;
            default:
                frame.sprite = emptyFrame;
                break;
        }
        /*if(throwingBehaviour.colorPickUp == 0)
        {
            frame.sprite = redFrame;
        }

        if(throwingBehaviour.colorPickUp == 1)
        {
            frame.sprite = blueFrame;
        }

        if (throwingBehaviour.colorPickUp == 2)
        {
            frame.sprite = greenFrame;
        }

        if(throwingBehaviour.colorPickUp == 3)
        {
            frame.sprite = yellowFrame;
        }

        if(throwingBehaviour.colorPickUp == -1)
        {
            frame.sprite = emptyFrame;
        }*/
    }
}
