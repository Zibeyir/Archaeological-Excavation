using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCanvas : MonoBehaviour
{
    public AnimationController AzAnime;
    public AnimationController EnAnime;
    public AnimationController BGAnime;

    public ColorAnimation colorAnimation;
    public Image image;
    void Start()
    {
        
    }
    public void StartCanvasOpen()
    {
        image.raycastTarget = true;
        colorAnimation.Open();
        BGAnime.PlayApearAnim();

        //AzAnime.PlayApearAnim();
        //EnAnime.PlayApearAnim();
    }
    public void StartCanvasClose()
    {
        print("StartCanvasClose");
        image.raycastTarget = false;
        colorAnimation.Close();
        BGAnime.PlayDisApearAnim();
        //AzAnime.PlayDisApearAnim();
        //EnAnime.PlayDisApearAnim();
    }
}
