using System.Collections;
using UnityEngine;

public class Story2 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{
		textbox.text = "スキルボタンを押してみよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "スキルボタンを押してみよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "スキルは3秒で終わるから気をつけて";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "＋ボタンで追加ポイントもらえるよ";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;
	}
}