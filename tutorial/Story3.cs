using System.Collections;
using UnityEngine;

public class Story3 : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	IEnumerator Start()
	{
		textbox.text = "敵の動きを観察しよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "敵の動きのパターンを見つけよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "敵の動きのパターンを見つけよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;

		textbox.text = "敵の動きのパターンを見つけよう";
		yield return new WaitUntil(() => Input.anyKeyDown);
		yield return null;
	}
}