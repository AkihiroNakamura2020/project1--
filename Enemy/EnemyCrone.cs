using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrone : MonoBehaviour
{
	private int count = 0;
	public GameObject originObject; //オリジナルのオブジェクト



	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 3)
			{
				Instantiate(originObject, new Vector3(4.0f, -0.5f, 9.0f), Quaternion.identity);
			}
	

			if (count == 6)
			{
				Instantiate(originObject, new Vector3(5.0f, -0.5f, 9.0f), Quaternion.identity);
			}


			if (count == 9)
			{
				Instantiate(originObject, new Vector3( 6.0f, -0.5f, 9.0f), Quaternion.identity);
    
			}

			if (count == 12)
			{
				Instantiate(originObject, new Vector3(7.0f, -0.5f, 9.0f), Quaternion.identity);

			}

			if (count == 15)
			{
				Instantiate(originObject, new Vector3(8.0f, -0.5f, 9.0f), Quaternion.identity);

			}

		}
	}
}