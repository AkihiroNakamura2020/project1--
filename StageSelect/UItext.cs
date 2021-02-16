using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UItext : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textbox;

	public int playstage;

	void Start()
	{
		//PlayerPrefs.DeleteAll();

		int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);      //どのステージまでクリアしているのかをロード（セーブされていなければ「０」）
		int clearStageNohd = PlayerPrefs.GetInt("CLEARhd", 0);//lavelhard
		int clearStageNohl = PlayerPrefs.GetInt("CLEARhl", 0);//lavelhell


		int clearlevel = PlayerPrefs.GetInt("LEVEL", 0);
		int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);

		int playstage = PlayerPrefs.GetInt("playstage", 1);//stageボタンクリックで認識ninposスクリプト
		string nowlevelname;

		if (nowlevel == 0)
		{
			nowlevelname = "EASY";
        }
        else if(nowlevel == 1)
		{

			nowlevelname = "HARD";
        }
        else
        {
			nowlevelname = "HELL";
		}


		if (clearlevel == 0)
		{

			if (clearStageNo == 0)
			{
				textbox.text = "称号：" + "子鹿さん" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;

			}

			if (clearStageNo == 1)
			{
				textbox.text = "称号：" + "お使いの達人" + "\n" + "STAGE: " + nowlevelname + " - "+ playstage;
			}

			if (clearStageNo == 2)
			{
				textbox.text = "称号：" + "タンポポ組" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNo == 3)
			{
				textbox.text = "称号：" + "1年1組" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNo == 4)
			{
				textbox.text = "称号：" + "学級委員" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNo == 5)
			{
				textbox.text = "称号：" + "生徒会長" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNo == 6)
			{
				textbox.text = "称号：" + "才能開花" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

		}
		if (clearlevel == 1)
		{

			if (clearStageNohd == 0)
			{
				textbox.text = "称号：" + "才能開花" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;

			}

			if (clearStageNohd == 1)
			{
				textbox.text = "称号：" + "忍者の卵" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohd == 2)
			{
				textbox.text = "称号：" + "忍者見習い" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohd == 3)
			{
				textbox.text = "称号：" + "下忍" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohd == 4)
			{
				textbox.text = "称号：" + "中忍" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohd == 5)
			{
				textbox.text = "称号：" + "上忍" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohd == 6)
			{
				textbox.text = "称号：" + "頭領" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

		}

		if (clearlevel == 2)
		{

			if (clearStageNohl == 0)
			{
				textbox.text = "称号：" + "頭領" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;

			}

			if (clearStageNohl == 1)
			{
				textbox.text = "称号：" + "求道者" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohl == 2)
			{
				textbox.text = "称号：" + "勇者" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohl == 3)
			{
				textbox.text = "称号：" + "怪物" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohl == 4)
			{
				textbox.text = "称号：" + "修羅" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohl == 5)
			{
				textbox.text = "称号：" + "亜神" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

			if (clearStageNohl == 6)
			{
				textbox.text = "称号：" + "神の系列" + "\n" + "STAGE: " + nowlevelname + " - " + playstage;
			}

		}


	}
}
