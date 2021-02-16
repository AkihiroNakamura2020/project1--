using System.Collections;
using UnityEngine;

public class Story1 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{
		textbox.text = "赤枠のボタンを押して動かしてみよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "矢印下のゴールまで行ってみよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "敵に当たらないように気をつけて";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

	}
}