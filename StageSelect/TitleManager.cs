using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
	public GameObject[] LevelButtons;


	// Use this for initialization
	void Start()
	{
		int clearlevel = PlayerPrefs.GetInt("LEVEL", 0);

		for (int i = 0; i <= LevelButtons.GetUpperBound(0); i++)
		{
			bool buttonEnable;

			if (clearlevel < i)
			{
				buttonEnable = false;   //前ステージをクリアしていなければ無効
			}
			else
			{
				buttonEnable = true;    //前ステージをクリアしていれば有効
			}

			LevelButtons[i].GetComponent<Button>().interactable = buttonEnable; //ボタンの有効/無効を設定
		}
	}

	//スタートボタンを押した
	public void PushStartButton()
	{
		SceneManager.LoadScene("StageSelect"); //ステージ選択シーンへ
	}

	public void PushStartButtonhard()
	{
		SceneManager.LoadScene("StageSelecthard"); //hardステージ選択シーンへ
	}

	public void PushStartButtonhell()
	{
		SceneManager.LoadScene("StageSelecthell"); //hellステージ選択シーンへ
	}
}
