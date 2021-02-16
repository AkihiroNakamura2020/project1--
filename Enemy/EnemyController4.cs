using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyController4 : MonoBehaviour
{
	GameObject Player;

	Vector3 MOVEX = new Vector3(1.0f, 0, 0);
	Vector3 MOVEY = new Vector3(0, 1.0f, 0);
	Vector3 MOVEZ = new Vector3(0, 0, 1.0f);

	private GameObject mainCamera;      //メインカメラ格納用
	private GameObject subCamera;       //サブカメラ格納用 



	Vector3 target;      // 入力受付時、移動後の位置を算出して保存 

	private int count = 0;

	void Start()
	{
		target = transform.position;

		this.Player = GameObject.Find("Player");
		mainCamera = GameObject.Find("MainCamera");
		subCamera = GameObject.Find("SubCamera");
	}

	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 1)
			{
				target = transform.position - MOVEX;
			}

			if (count == 2)
			{
				target = transform.position - MOVEX;
			}


			if (count == 3)
			{
				target = transform.position + MOVEX;

			}
			if (count == 4)
			{
				target = transform.position + MOVEX;
				count = 0;

			}

		}
		Move();

		Vector3 p1 = transform.position;
		Vector3 p2 = this.Player.transform.position;



		if (p1 == p2)
		{
			if (Player != null)
			{
				//Camera.main.transform.SetParent(null);
				//subCamera.transform.SetParent(null);
				Player.transform.DetachChildren();

				//this.Player.SetActive(false);

				Destroy(Player);
				Invoke("Over", 0);


			}
		}


	}
	void Move()
	{
		this.transform.position = target;
	}
	void Over()
	{
		SceneManager.LoadScene("GameOver");
	}

}
