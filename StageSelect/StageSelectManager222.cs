using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StageSelectManager222 : MonoBehaviour
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

	public int clearlevel;



	void Start()
	{
		//PlayerPrefs.DeleteAll();

		int clearStageNohl = PlayerPrefs.GetInt("CLEARhl", 0);      //どのステージまでクリアしているのかをロード（セーブされていなければ「０」）

		clearlevel = PlayerPrefs.GetInt("LEVEL", 0);//easy0,hard1,hell2


													//ステージボタンを有効化
		for (int i = 0; i <= stageButtons.GetUpperBound(0); i++)
		{
			bool buttonEnable;

			if (clearStageNohl < i)
			{
				buttonEnable = false;   //前ステージをクリアしていなければ無効
			}
			else
			{
				buttonEnable = true;    //前ステージをクリアしていれば有効
			}

			stageButtons[i].GetComponent<Button>().interactable = buttonEnable; //ボタンの有効/無効を設定
		}

		clearlevel = 2;
		PlayerPrefs.SetInt("LEVEL", clearlevel);
		PlayerPrefs.Save();
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
		nowlevel = 2;
		PlayerPrefs.SetInt("nowLEVEL", nowlevel);
		PlayerPrefs.Save();

		if (nowlevel > clearlevel)
		{
			clearlevel = nowlevel; //nowlevelはstageselectで定義済み、titlemanageの補足
			PlayerPrefs.SetInt("LEVEL", clearlevel);
			PlayerPrefs.Save();
		}

		//　ロード画面UIをアクティブにする
		loadUI.SetActive(true);

		//　コルーチンを開始
		StartCoroutine("PushStageSelectButton" + stageNo);
	}


	IEnumerator PushStageSelectButton1()
	{
		// シーンの読み込みをする
		async = SceneManager.LoadSceneAsync("GameScene31");

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
		async = SceneManager.LoadSceneAsync("GameScene32");

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
		async = SceneManager.LoadSceneAsync("GameScene33");

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
		async = SceneManager.LoadSceneAsync("GameScene34");

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
		async = SceneManager.LoadSceneAsync("GameScene35");

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
		async = SceneManager.LoadSceneAsync("GameScene36");

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
