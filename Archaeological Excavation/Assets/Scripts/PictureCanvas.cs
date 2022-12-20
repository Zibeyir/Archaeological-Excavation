using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureCanvas : MonoBehaviour
{
    [Header("Parent")]
    [SerializeField] GameObject PicturesParent;
    [SerializeField] GameObject PictureButtonsParent;
    [Header("Prefab")]
    [SerializeField] GameObject PicturePrefab;
    [SerializeField] GameObject PictureButtonsPrefab;
    List<GameObject> _spritesPictures;
    List<GameObject> _spritesPictureButtons;

    public void GetPictures(List<Sprite> spritesPictures)
    {
        foreach (var item in _spritesPictures)
        {
            Destroy(item);
        }
        _spritesPictures.Clear();
        for (int i = 0; i < spritesPictures.Count; i++)
        {
            GameObject gameObject = Instantiate(PicturePrefab, PicturesParent.transform);
            gameObject.GetComponent<Image>().sprite = spritesPictures[i];
            gameObject.transform.parent = PicturesParent.transform;
            _spritesPictures.Add(gameObject);
        }
    }
    public void GetPictureButtons(List<Sprite> spritesPictureButtons)
    {
        foreach (var item in _spritesPictureButtons)
        {
            Destroy(item);
        }
        _spritesPictureButtons.Clear();
        for (int i = 0; i < spritesPictureButtons.Count; i++)
        {
            GameObject gameObject = Instantiate(PicturePrefab, PicturesParent.transform);
            gameObject.GetComponent<Image>().sprite = spritesPictureButtons[i];
            gameObject.transform.parent = PictureButtonsParent.transform;
            _spritesPictureButtons.Add(gameObject);

        }
    }
  
}

