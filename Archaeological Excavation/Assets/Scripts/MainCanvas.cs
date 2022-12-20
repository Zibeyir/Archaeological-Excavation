using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public AnimationController PictureScrollCanvas;
    void Start()
    {
        
    }

    public void Back()
    {
        if (PictureScrollCanvas.opened)
        {
            PictureScrollCanvas.PlayDisApearAnim();
        }
    }

    public void SelectMainButton()
    {

        PictureScrollCanvas.PlayApearAnim();
    }
}
