using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;



public class DragEventTest2 : MonoBehaviour
{
	[SerializeField] private GameObject test;//操作対象sphere
	[SerializeField] private GameObject test1;//操作用image

	Vector3 testpos;//操作対象sphere
	Vector3 test1pos;//操作用image
	//imageをドラッグで操作することで、その移動分を操作対象オブジェクトに加算したい

	void Start()
	{
		testpos = test.transform.position;
		test1pos = test1.transform.position;

	}

	void Update()
	{
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint(test1.transform.position);//ワールド座標への変換
																					 //TargetPos.z = 0;
		Vector3 STargetPos = Camera.main.ScreenToWorldPoint(test1pos);//image初期地点のワールド座標


		//testpos += test1pos;
		//test.transform.position += TargetPos;
		//Vector3 AddPos = new Vector3 (7,5,0);//sphere初期位置調整用

		Vector3 AddPos = TargetPos - STargetPos;
		test.transform.position = testpos + AddPos;


	}


}