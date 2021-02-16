using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CrownManager : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;


	void Start()
	{
		//PlayerPrefs.DeleteAll();

		int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);
		int clearStageNohd = PlayerPrefs.GetInt("CLEARhd", 0);//lavelhard
		int clearStageNohl = PlayerPrefs.GetInt("CLEARhl", 0);//lavelhell

		//int playstage = PlayerPrefs.GetInt("playstage", 1);
		//int playstagehd = PlayerPrefs.GetInt("playstagehd", 1);//levelhard
		//int playstagehl = PlayerPrefs.GetInt("playstagehl", 1);//levelhell


		//int laststage = PlayerPrefs.GetInt("Last", 0);
		//int laststagehd = PlayerPrefs.GetInt("Lasthd", 0);//levelhard
		//int laststagehl = PlayerPrefs.GetInt("Lasthl", 0);//levelhell


		int point_num = PlayerPrefs.GetInt("CPoint", 2);

		int clearlevel = PlayerPrefs.GetInt("LEVEL", 0);
		int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);

		//Debug.Log("c"+clearStageNo);
		//Debug.Log("p" + playstage);
		//Debug.Log("l" + laststage);
		Debug.Log("LE" + clearlevel);
		Debug.Log("NLE" + nowlevel);
		Debug.Log("CH" + clearStageNohl);




		if (clearlevel == 0)//leveleasy
		{
			//if (clearStageNo == 0) DeleteALLの場合

			if (clearStageNo == 0)
			{
				textbox.text = "子鹿さん";

			}


			if (clearStageNo == 1)
				{
					textbox.text = "お使いの達人";

				}

				if (clearStageNo == 2)
				{
					textbox.text = "タンポポ組";
				}

				if (clearStageNo == 3)
				{
					textbox.text = "1年1組";

				}

				if (clearStageNo == 4)
				{
					textbox.text = "学級委員";
				}

				if (clearStageNo == 5)
				{
					textbox.text = "生徒会長";
				}

				if (clearStageNo == 6)
				{
					textbox.text = "才能開花";

				}

		}

		if (clearlevel == 1)//levelhard
		{


			//if (clearStageNo == 0) DeleteALLの場合

			if (clearStageNohd == 0)
			{
				textbox.text = "才能開花";

			}


			if (clearStageNohd == 1)
				{
					textbox.text = "忍者の卵";

				}

				if (clearStageNohd == 2)
				{
					textbox.text = "忍者見習い";

				}

				if (clearStageNohd == 3)
				{
					textbox.text = "下忍";

				}

				if (clearStageNohd == 4)
				{
					textbox.text = "中忍";
				}

				if (clearStageNohd == 5)
				{
					textbox.text = "上忍";
				}

				if (clearStageNohd == 6)
				{
					textbox.text = "頭領";


				}

			}



		if (clearlevel == 2)//levelhard
		{


			if (clearStageNohl == 0)
			{
				textbox.text = "頭領";

			}

			if (clearStageNohl == 1)
				{
					textbox.text = "求道者";

				}

				if (clearStageNohl == 2)
				{
					textbox.text = "勇者";

				}

				if (clearStageNohl == 3)
				{
					textbox.text = "怪物";
				}

				if (clearStageNohl == 4)
				{
					textbox.text = "修羅";
				}

				if (clearStageNohl == 5)
				{
					textbox.text = "亜神";
				}

				if (clearStageNohl == 6)
				{
					textbox.text = "神の系列";
				}

			}
		
	}
}