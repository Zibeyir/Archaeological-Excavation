using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MainButtonBool : MonoBehaviour
{
    public string Name;
    public Image Appear;
    public Image DisAppear;
    public float time;

    void Start()
    {
        Name = gameObject.name;
        ImageF(false);
    }

    public void SelectMainButton()
    {
        GameManager.instance.ButtonMainButtons(this);
    }

    public void ImageF(bool x)
    {
        if (x)
        {
            Appear.DOFade(1, time);
            DisAppear.DOFade(0, time);
        }
        else
        {
            Appear.DOFade(0, time);
            DisAppear.DOFade(1, time);
        }
    }
}
