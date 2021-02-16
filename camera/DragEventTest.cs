using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragEventTest : MonoBehaviour, IDragHandler
{

	public void OnDrag(PointerEventData data)
	{
		Vector3 TargetPos = data.position;
		TargetPos.z = 0;
		transform.position = TargetPos;

	}
}