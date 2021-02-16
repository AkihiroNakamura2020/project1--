﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyWarp23 : MonoBehaviour
{
	[SerializeField] GameObject Fade;

	GameObject Player;
	Animator anim;

	Vector3 MOVEX = new Vector3(1.0f, 0, 0);
	Vector3 MOVEY = new Vector3(0, 1.0f, 0);
	Vector3 MOVEZ = new Vector3(0, 0, 1.0f);



	Vector3 target;      // 入力受付時、移動後の位置を算出して保存 

	private int count = 0;

	void Start()
	{
		target = transform.position;

		this.Player = GameObject.Find("Player");

	}

	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;
			//anim = GetComponent<Animator>();
			//this.anim.SetTrigger("walk");


			if (count == 1)
			{
				Vector3 pos = new Vector3(1, -0.5f, 1);

				target = pos;

				//anim = GetComponent<Animator>();
				//this.anim.SetTrigger("idle");
				//transform.rotation = Quaternion.Euler(0, 270, 0);


			}

			if (count == 2)
			{

				Vector3 pos = new Vector3(0, -0.5f, 4);

				target = pos;


			}


			if (count == 11)
			{


				Vector3 pos = new Vector3(7, -0.5f, 4);

				target = pos;


			}

			if (count == 12)
			{


				Vector3 pos = new Vector3(4, -0.5f, 5);

				target = pos;


			}


		}




		Move();

		Vector3 p1 = transform.position;
		Vector3 p2 = this.Player.transform.position;



		if (p1 == p2)
		{
			Fadeover();


			if (Player != null)
			{
				//Camera.main.transform.SetParent(null);
				//subCamera.transform.SetParent(null);
				//Player.transform.DetachChildren();

				//this.Player.SetActive(false);

				//Destroy(Player);
				Invoke("Over", 1);


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
	void Fadeover()
	{
		Fade.SetActive(true);
	}

}
