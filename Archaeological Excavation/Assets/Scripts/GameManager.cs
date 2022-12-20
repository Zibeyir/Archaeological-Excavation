using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LangDropDown langDropDown;

    [Header("Canvases")]
    public StartCanvas StartCanvasScript;
    public MainCanvas MainCanvasScript;
    public List<MainButtonsStructure> mainButtonsStructures;
    void Start()
    {
        mainButtonsStructures = new List<MainButtonsStructure>();
    }


    #region Buttons


    public void ButtonSelectLanguage(string l)
    {
        print("ButtonSelectLanguage");
        langDropDown.ChangeLanaguage(l);
        StartCanvasScript.StartCanvasClose();
    }

    public void ButtonMainButtons()
    {
        MainCanvasScript.SelectMainButton();
    }

    public void ButtonBack()
    {
        if (MainCanvasScript.PictureScrollCanvas.opened)
        {
            MainCanvasScript.Back();
        }
        else
        {
            StartCanvasScript.StartCanvasOpen();
        }
    }

    #endregion
}

[System.Serializable]
public class MainButtonsStructure
{
    public Sprite sprite;
    public List<MainImagessStructure> mainImagessStructures;

}

[System.Serializable]
public class MainImagessStructure
{
    public List<Sprite> sprites;
    // public List<>

}
