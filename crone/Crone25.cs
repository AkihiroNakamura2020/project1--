using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crone25 : MonoBehaviour
{
	private int count = 0;
	public GameObject originObject; //オリジナルのオブジェクト



	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 15)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(0.0f, -0.5f, 7.0f), q);
			}

			if (count == 16)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(2.0f, -0.5f, 8.0f), q);
			}

			if (count == 17)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(3.0f, -0.5f, 9.0f), q);
			}
			if (count == 18)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 9.0f), q);
			}



		}
	}
}

