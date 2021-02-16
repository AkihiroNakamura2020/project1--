using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Drag3 : MonoBehaviour, IDragHandler, IEndDragHandler
{
	public GameObject respawn;

	public void OnDrag(PointerEventData data)
	{
		Vector3 TargetPos = data.position;
		TargetPos.z = 0;
		transform.position = TargetPos;
		Debug.Log("100");
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log(3);
		//Vector3 StartPos = Vector3.zero;
		//Vector3 StartPos = transform.InverseTransformPoint(Vector3.zero);
		Vector3 StartPos = new Vector3(2131,258,0);


		transform.position = StartPos;

		Debug.Log(eventData);//ワールド座標での移動量
		Vector2 tapPosition = transform.InverseTransformPoint(eventData.position);
		Debug.Log(tapPosition);//ローカル座標での移動量

		
		respawn = GameObject.FindWithTag("Respawn");
		Transform respawnpos;

		//respawnpos += respawn.transform.position + tapPosition;

	}

}