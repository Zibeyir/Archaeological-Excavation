using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureColor : MonoBehaviour
{
    public Image image;
    Transform scale;
    void OnEnable()
    {
        scale = GetComponent<Transform>();
        image = GetComponentInChildren<Image>();
    }
   
    void Update()
    {

        image.color = new Color(1, 1, 1, (scale.localScale.x - 0.3f) * 2);
       
    }
}
