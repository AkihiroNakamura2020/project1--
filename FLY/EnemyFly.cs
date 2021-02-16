using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;


public class EnemyFly : MonoBehaviour
{
	[SerializeField] GameObject Fade;

	//	[SerializeField] Button Bleft;
	//	[SerializeField] Button Bright;
	//	[SerializeField] Button Bup;
	//	[SerializeField] Button Bdown;

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


			if (count == 2)
			{
				target = transform.position + MOVEY*2;

			}

			if (count == 3)
			{
				target = transform.position + MOVEY * 2;

			}


			if (count == 5)
			{
				target = transform.position - MOVEY * 2;

			}
			if (count == 6)
			{
				target = transform.position - MOVEY * 2;

				count = 0;

			}

		}
		Move();

		Vector3 p1 = transform.position;
		Vector3 p2 = this.Player.transform.position;



		if (p1 == p2)
		{
			Fadeover();

			//Bleft.interactable = false;
			//Bright.interactable = false;
			//Bup.interactable = false;
			//Bdown.interactable = false;


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
