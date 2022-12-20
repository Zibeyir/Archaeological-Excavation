using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCanvas : MonoBehaviour
{
    public AnimationController PictureScrollCanvas;
    public MainButtonBool[] mainButtonBools;
    bool Activator;
    void Start()
    {
        mainButtonBools =(MainButtonBool[]) GameObject.FindObjectsOfType(typeof(MainButtonBool));

    }

    public void Back()
    {
        if (PictureScrollCanvas.opened)
        {
            PictureScrollCanvas.PlayDisApearAnim();
            foreach (var item in mainButtonBools)
            {
                item.ImageF(false);
            }
        }
    }

    public void SelectMainButton(MainButtonBool mainButtonBool)
    {
        foreach (var item in mainButtonBools)
        {
            Activator = item == mainButtonBool ? true : false;
            item.ImageF(Activator);
        }
        PictureScrollCanvas.PlayApearAnim();
    }
}
