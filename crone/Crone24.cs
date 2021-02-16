using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crone24 : MonoBehaviour
{
	private int count = 0;
	public GameObject originObject; //オリジナルのオブジェクト



	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 1)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(5.0f, -0.5f, 3.0f), q);
			}

			if (count == 2)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(6.0f, -0.5f, 3.0f), q);
			}


			if (count == 3)
			{
				Quaternion q = Quaternion.Euler(0f, 0.0f, 0.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 4.0f), q);
			}


			if (count == 4)
			{
				Quaternion q = Quaternion.Euler(0f, 0.0f, 0.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 5.0f), q);

			}

			if (count == 5)
			{
				Quaternion q = Quaternion.Euler(0f, 270.0f, 0.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 6.0f), q);

			}

			if (count == 6)
			{
				Quaternion q = Quaternion.Euler(0f, 0.0f, 0.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 8.0f), q);

			}
			if (count == 7)
			{
				Quaternion q = Quaternion.Euler(0f, 0.0f, 0.0f);

				Instantiate(originObject, new Vector3(4.0f, -0.5f, 9.0f), q);

			}


		}
	}
}

