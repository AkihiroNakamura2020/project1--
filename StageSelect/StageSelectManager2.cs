using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectManager2 : MonoBehaviour
{
	public GameObject[] stageButtons;   //ステージ選択ボタン配列

	//　非同期動作で使用するAsyncOperation
	private AsyncOperation async;
	//　シーンロード中に表示するUI画面
	[SerializeField]
	private GameObject loadUI;
	//　読み込み率を表示するスライダー
	[SerializeField]
	private Slider slider;


	void Start()
	{
		//PlayerPrefs.DeleteAll();

		int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);      //どのステージまでクリアしているのかをロード（セーブされていなければ「０」）

		//ステージボタンを有効化
		for (int i = 0; i <= stageButtons.GetUpperBound(0); i++)
		{
			bool buttonEnable;

			if (clearStageNo < i)
			{
				buttonEnable = false;   //前ステージをクリアしていなければ無効
			}
			else
			{
				buttonEnable = true;    //前ステージをクリアしていれば有効
			}

			stageButtons[i].GetComponent<Button>().interactable = buttonEnable; //ボタンの有効/無効を設定
		}
		if (clearStageNo == 6)
		{
			int clearlevel = PlayerPrefs.GetInt("LEVEL", 0);

            if (clearlevel < 1)
			{
				clearlevel = 1;
				PlayerPrefs.SetInt("LEVEL", clearlevel);
				PlayerPrefs.Save();
			}
			
		}

	}

	void Update()
	{

	}

	//ステージ選択ボタンを押した
	//public void PushStageSelectButton(int stageNo)
	
		//SceneManager.LoadScene("GameScene" + stageNo);  //ゲームシーンへ
	

	public void NextScene(int stageNo)
	{
		int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);
		nowlevel = 0;
		PlayerPrefs.SetInt("nowLEVEL", nowlevel);
		PlayerPrefs.Save();

		Debug.Log("NLE" + nowlevel);

		//　ロード画面UIをアクティブにする
		loadUI.SetActive(true);

		//　コルーチンを開始
		StartCoroutine("PushStageSelectButton" + stageNo);
	}


	IEnumerator PushStageSelectButton1()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene1");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}

	IEnumerator PushStageSelectButton2()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene2");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}

	IEnumerator PushStageSelectButton3()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene3");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}
	IEnumerator PushStageSelectButton4()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene4");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}
	IEnumerator PushStageSelectButton5()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene5");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}
	IEnumerator PushStageSelectButton6()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene6");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}

	public void BackScene()
	{
		//　ロード画面UIをアクティブにする
		loadUI.SetActive(true);

		//　コルーチンを開始
		StartCoroutine("BackSeneloading");
		//SceneManager.LoadScene("TitleScene");
	}

	IEnumerator BackSeneloading()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("TitleScene");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}

	public void CrownScene()
	{
		//　ロード画面UIをアクティブにする
		loadUI.SetActive(true);

		//　コルーチンを開始
		StartCoroutine("Crownloading");
		//SceneManager.LoadScene("TitleScene");
	}

	IEnumerator Crownloading()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("Crown");

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}

}
