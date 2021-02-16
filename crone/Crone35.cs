using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crone35 : MonoBehaviour
{
	private int count = 0;
	public GameObject originObject; //オリジナルのオブジェクト



	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 5)
			{
				Quaternion q = Quaternion.Euler(30.0f, 0.0f, 45.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 2.0f), q);


			}

			if (count == 8)
			{
				Quaternion q = Quaternion.Euler(30.0f, 0.0f, 45.0f);

				Instantiate(originObject, new Vector3(6.0f, -0.5f, 2.0f), q);


			}

			if (count == 9)
			{
				Quaternion q = Quaternion.Euler(30.0f, 0.0f, 45.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 6.0f), q);


			}

			if (count == 14)
			{
				Quaternion q = Quaternion.Euler(30.0f, 0.0f, 45.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 8.0f), q);


			}

			if (count == 17)
			{
				Quaternion q = Quaternion.Euler(30.0f, 0.0f, 45.0f);

				Instantiate(originObject, new Vector3(8.0f, -0.5f, 7.0f), q);


			}
			if (count == 18)
			{
				Quaternion q = Quaternion.Euler(30.0f, 0.0f, 45.0f);

				Instantiate(originObject, new Vector3(9.0f, -0.5f, 7.0f), q);


			}
		


		}
	}
}

