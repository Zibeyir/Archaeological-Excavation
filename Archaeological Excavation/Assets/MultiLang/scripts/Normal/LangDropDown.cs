using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LangDropDown : MonoBehaviour
{
	int index;

	
	public void ChangeLanaguage(string l)
    {
		index = PlayerPrefs.GetInt("_language_index", 0); ;
		PlayerPrefs.SetInt("_language_index", index);
		PlayerPrefs.SetString("_language", l);
		ApplyLanguageChanges();
	}
	void ApplyLanguageChanges ()
	{
		GameMultiLang.Instance.LoadLanguage();
	}

	
}
