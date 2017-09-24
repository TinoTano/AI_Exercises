using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToMenuButton : MonoBehaviour {

	void Start()
	{
		Button btn = GetComponent<Button>();
		btn.onClick.AddListener(BackToMenu);
	}

	public void BackToMenu()
	{
		SceneManager.LoadScene (0);
	}
}
