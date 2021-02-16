using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragEventCamera : MonoBehaviour, IDragHandler, IEndDragHandler
{
	[SerializeField] private GameObject test;//操作対象subcamera

	Transform testTransform;//操作対象subcamera
	Vector3 test1pos;//操作用image
					 //imageをドラッグで操作することで、その移動分を操作対象オブジェクトに加算したい
	Vector3 testbaseangle;

	void Start()
	{
		testTransform = test.gameObject.GetComponent<Transform>();

		test1pos = transform.position;

		testbaseangle = testTransform.eulerAngles;

	}

	public void OnDrag(PointerEventData data)
	{
		Vector3 TargetPos = data.position;
		TargetPos.z = 0;
		transform.position = TargetPos;

		//追加

		Vector3 FinalPos = Camera.main.ScreenToWorldPoint(transform.position);//現image座標のワールド座標への変換
																			   //TargetPos.z = 0;
		Vector3 STargetPos = Camera.main.ScreenToWorldPoint(test1pos);//image初期地点のワールド座標

		Vector3 AddPos = FinalPos - STargetPos;

		Vector3 worldAngle = testTransform.eulerAngles;


		worldAngle.y = AddPos.x * 10;

		testTransform.eulerAngles = worldAngle;
	}

	public void OnEndDrag(PointerEventData eventData)
	{

		testTransform.eulerAngles = testbaseangle;//subcameraの角度を初期値へ

		transform.position = test1pos;//imageの場所を初期位置へ

	}

}