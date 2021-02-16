using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ORotate : MonoBehaviour
{
	[SerializeField] private GameObject test;//操作対象sphere
	[SerializeField] private GameObject test1;//操作用image

	Transform testTransform;//操作対象sphere
	Vector3 test1pos;//操作用image
					 //imageをドラッグで操作することで、その移動分を操作対象オブジェクトに加算したい

	void Start()
	{
		testTransform = test.gameObject.GetComponent<Transform>();


		test1pos = test1.transform.position;

	}

	void Update()
	{
		Vector3 TargetPos = Camera.main.ScreenToWorldPoint(test1.transform.position);//ワールド座標への変換
																					 //TargetPos.z = 0;
		Vector3 STargetPos = Camera.main.ScreenToWorldPoint(test1pos);//image初期地点のワールド座標

		Vector3 AddPos = TargetPos - STargetPos;

		Vector3 worldAngle = testTransform.eulerAngles;

		worldAngle.y = AddPos.x;

		testTransform.eulerAngles = worldAngle;


		//test.transform.position = testpos + AddPos;


	}


}