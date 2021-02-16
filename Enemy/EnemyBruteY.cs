using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyBruteY : MonoBehaviour
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
				target = transform.position - MOVEZ;
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");


				//transform.rotation = Quaternion.Euler(0, 270, 0);


			}

			if (count == 2)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");

				target = transform.position - MOVEZ;


			}


			if (count == 3)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");

				target = transform.position - MOVEY;

				transform.rotation = Quaternion.Euler(0, 90, 0);


			}
			if (count == 4)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");

				target = transform.position + MOVEY;
				//count = 0;

			}

			if (count == 5)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");

				target = transform.position - MOVEZ;


			}


			if (count == 6)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");

				target = transform.position + MOVEX;

				transform.rotation = Quaternion.Euler(0, 90, 0);


			}
			if (count == 7)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("walk");

				target = transform.position - MOVEX;
				transform.rotation = Quaternion.Euler(0, 270, 0);
				//count = 0;

			}
			if (count >= 8)
			{
				anim = GetComponent<Animator>();
				this.anim.SetTrigger("idle");
				//count = 0;

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
