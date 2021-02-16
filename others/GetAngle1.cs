using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAngle1 : MonoBehaviour
{

	[SerializeField]
	GameObject _start;

	[SerializeField]
	GameObject _target;



    void Update()
    {
		float angle = GetAngle(_start.transform.position, _target.transform.position);
	}

    float GetAngle(Vector3 start, Vector3 target)
	{
		Vector3 dt = target - start;
		float rad = Mathf.Atan2(dt.z, dt.x);
		float degree = rad * Mathf.Rad2Deg;

		return degree;
	}
}