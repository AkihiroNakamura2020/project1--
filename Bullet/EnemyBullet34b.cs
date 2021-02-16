using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyBullet34b : MonoBehaviour
{
	[SerializeField] GameObject Fade;
	public GameObject originObject; //オリジナルのオブジェクト


	GameObject Player;
	//Animator anim;

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

			if (count == 1)
			{
				target = transform.position + MOVEZ;

				

			}

			if (count == 2)
			{

				target = transform.position + MOVEZ;


			}


			if (count == 3)
			{

				target = transform.position + MOVEZ;



			}
			if (count == 4)
			{

				target = transform.position + MOVEZ;


			}
			if (count == 5)
			{

				target = transform.position - MOVEZ * 4;



			}
			if (count == 6)
			{
				target = transform.position + MOVEZ;


			}

			if (count == 7)
			{

				target = transform.position + MOVEZ;


			}


			if (count == 8)
			{

				target = transform.position + MOVEZ;



			}
			if (count == 9)
			{

				target = transform.position + MOVEZ;


			}
			if (count == 10)
			{

				target = transform.position - MOVEZ * 4;


			}
			if (count == 11)
			{
				target = transform.position + MOVEZ;


			}

			if (count == 12)
			{

				target = transform.position + MOVEZ;


			}


			if (count == 13)
			{

				target = transform.position + MOVEZ;



			}
			if (count == 14)
			{

				target = transform.position + MOVEZ;


			}
			if (count == 15)
			{

				target = transform.position - MOVEZ * 4;


			}

			if (count == 16)
			{
				target = transform.position + MOVEZ;


			}

			if (count == 17)
			{

				target = transform.position + MOVEZ;


			}


			if (count == 18)
			{

				target = transform.position + MOVEZ;
				

				//count = 0;
			}

			if (count == 19)
			{
				Quaternion q = Quaternion.Euler(0f, 180.0f, 0.0f);

				Instantiate(originObject, new Vector3(8.0f, -0.5f, 3.0f), q);

				target = transform.position + MOVEZ;


			}

			if (count == 20)
			{
				target = transform.position - MOVEZ * 4;

				count = 1;
			}




			Move();

			Vector3 p1 = transform.position;
			Vector3 p2 = this.Player.transform.position;



			if (p1 == p2)
			{
				Fadeover();


				if (Player != null)
				{
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
}
