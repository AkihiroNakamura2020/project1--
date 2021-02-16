using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyFlamePar35 : MonoBehaviour
{
	[SerializeField] GameObject Fade;

	[SerializeField] ParticleSystem particle;

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

		particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);

	}

	void Update()
	{
		if (Input.anyKeyDown)
		{
			count++;


			if (count == 1)
			{
				target = transform.position + MOVEY;//判定ずらし


			}

			if (count == 12)
			{

				target = transform.position - MOVEY;//hit判定戻し
				particle.Play(true);


			}

			
			if (count == 13)
			{
				target = transform.position + MOVEY;
				particle.Stop(true, ParticleSystemStopBehavior.StopEmitting);
				count = 6;
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
