using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManage : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;
	[SerializeField] GameObject item;


	void Start()
	{
		//PlayerPrefs.DeleteAll();

		int clearStageNo = PlayerPrefs.GetInt("CLEAR", 0);
		int clearStageNohd = PlayerPrefs.GetInt("CLEARhd", 0);//lavelhard
		int clearStageNohl = PlayerPrefs.GetInt("CLEARhl", 0);//lavelhell

		int playstage = PlayerPrefs.GetInt("playstage", 1);
		int playstagehd = PlayerPrefs.GetInt("playstagehd", 1);//levelhard
		int playstagehl = PlayerPrefs.GetInt("playstagehl", 1);//levelhell


		int laststage = PlayerPrefs.GetInt("Last", 0);
		int laststagehd = PlayerPrefs.GetInt("Lasthd", 0);//levelhard
		int laststagehl = PlayerPrefs.GetInt("Lasthl", 0);//levelhell


		int point_num = PlayerPrefs.GetInt("CPoint", 2);

		int clearlevel = PlayerPrefs.GetInt("LEVEL", 0);
		int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);

		//Debug.Log("c"+clearStageNo);
		//Debug.Log("p" + playstage);
		//Debug.Log("l" + laststage);
		Debug.Log("LE" + clearlevel);
		Debug.Log("NLE" + nowlevel);


		item.SetActive(false);

		if (clearlevel == 0)//leveleasy
		{

			if (clearStageNo > laststage)
			{

				//if (clearStageNo == 0) DeleteALLの場合

				item.SetActive(true);

				if (clearStageNo == 1)
				{
					textbox.text = "お使いの達人";

					laststage = clearStageNo;
					PlayerPrefs.SetInt("Last", laststage);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNo == 2)
				{
					textbox.text = "タンポポ組";

					laststage = clearStageNo;
					PlayerPrefs.SetInt("Last", laststage);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNo == 3)
				{
					textbox.text = "1年1組";
					laststage = clearStageNo;
					PlayerPrefs.SetInt("Last", laststage);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNo == 4)
				{
					textbox.text = "学級委員";
					laststage = clearStageNo;
					PlayerPrefs.SetInt("Last", laststage);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();
				}

				if (clearStageNo == 5)
				{
					textbox.text = "生徒会長";
					laststage = clearStageNo;
					PlayerPrefs.SetInt("Last", laststage);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();
				}

				if (clearStageNo == 6)
				{
					textbox.text = "才能開花";
					laststage = clearStageNo;
					PlayerPrefs.SetInt("Last", laststage);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				

				}
				
					
				

			}
			else
			{
				textbox.enabled = false;
			}
		}

		if (clearlevel == 1)//levelhard
		{

			if (clearStageNohd > laststagehd)
			{

				//if (clearStageNo == 0) DeleteALLの場合

				item.SetActive(true);

				if (clearStageNohd == 1)
				{
					textbox.text = "忍者の卵";

					laststagehd = clearStageNohd;
					PlayerPrefs.SetInt("Lasthd", laststagehd);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNohd == 2)
				{
					textbox.text = "忍者見習い";

					laststagehd = clearStageNohd;
					PlayerPrefs.SetInt("Lasthd", laststagehd);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNohd == 3)
				{
					textbox.text = "下忍";
					laststagehd = clearStageNohd;
					PlayerPrefs.SetInt("Lasthd", laststagehd);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNohd == 4)
				{
					textbox.text = "中忍";
					laststagehd = clearStageNohd;
					PlayerPrefs.SetInt("Lasthd", laststagehd);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();
				}

				if (clearStageNohd == 5)
				{
					textbox.text = "上忍";
					laststagehd = clearStageNohd;
					PlayerPrefs.SetInt("Lasthd", laststagehd);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();
				}

				if (clearStageNohd == 6)
				{
					textbox.text = "頭領";
					laststagehd = clearStageNohd;
					PlayerPrefs.SetInt("Lasthd", laststagehd);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

					

				}
					//clearlevel = 2;
					//PlayerPrefs.SetInt("LEVEL", clearlevel);
					//PlayerPrefs.Save();
				

			}
			else
			{
				textbox.enabled = false;
			}


		}

		if (clearlevel == 2)//levelhard
		{

			if (clearStageNohl > laststagehl)
			{

				//if (clearStageNo == 0) DeleteALLの場合

				item.SetActive(true);

				if (clearStageNohl == 1)
				{
					textbox.text = "求道者";

					laststagehl = clearStageNohl;
					PlayerPrefs.SetInt("Lasthl", laststagehl);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNohl == 2)
				{
					textbox.text = "勇者";

					laststagehl = clearStageNohl;
					PlayerPrefs.SetInt("Lasthl", laststagehl);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNohl == 3)
				{
					textbox.text = "怪物";
					laststagehl = clearStageNohl;
					PlayerPrefs.SetInt("Lasthd", laststagehl);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

				}

				if (clearStageNohd == 4)
				{
					textbox.text = "修羅";
					laststagehl = clearStageNohl;
					PlayerPrefs.SetInt("Lasthl", laststagehl);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();
				}

				if (clearStageNohl == 5)
				{
					textbox.text = "亜神";
					laststagehl = clearStageNohl;
					PlayerPrefs.SetInt("Lasthl", laststagehl);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();
				}

				if (clearStageNohl == 6)
				{
					textbox.text = "神の系列";
					laststagehl = clearStageNohl;
					PlayerPrefs.SetInt("Lasthl", laststagehl);

					point_num += 1;
					PlayerPrefs.SetInt("CPoint", point_num);
					PlayerPrefs.Save();

					//clearlevel = 2;
					//PlayerPrefs.SetInt("LEVEL", clearlevel);
					//PlayerPrefs.Save();

				}

			}
			else
			{
				textbox.enabled = false;
			}
		}
	}
}