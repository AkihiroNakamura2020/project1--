using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoalController : MonoBehaviour
{
	[SerializeField] GameObject Fade;

	GameObject Player;

	public int stageNo;

	public int clearlevel;
	public int nowlevel;

	public AudioClip sound1;
	AudioSource audioSource;


	void Start()
	{

		this.Player = GameObject.Find("Player");
		clearlevel = PlayerPrefs.GetInt("LEVEL", 0);//easy0,hard1,hell2
		int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);

		audioSource = GetComponent<AudioSource>();


	}

	void Update()
	{
		

		Vector3 p1 = transform.position;
		Vector3 p2 = this.Player.transform.position;



		if (p1 == p2)
		{
			Fadeover();
			audioSource.PlayOneShot(sound1);


			if (Player != null)
			{
				Invoke("Goal", 1.0f);

			}
		}


	}
	
	void Goal()
	{
		if (clearlevel == 0)
		{
			if (PlayerPrefs.GetInt("CLEAR,0") < stageNo)
			{
				PlayerPrefs.SetInt("CLEAR", stageNo);
				PlayerPrefs.Save();
			}
		}

		if(clearlevel ==1)
        {
			if (PlayerPrefs.GetInt("CLEARhd,0") < stageNo)
			{
				PlayerPrefs.SetInt("CLEARhd", stageNo);
				PlayerPrefs.Save();
			}

		}
		if (clearlevel == 2)
		{
			if (PlayerPrefs.GetInt("CLEARhl,0") < stageNo)
			{
				PlayerPrefs.SetInt("CLEARhl", stageNo);
				PlayerPrefs.Save();
			}

		}


		SceneManager.LoadScene("Goal");
	}
	void Fadeover()
	{
		Fade.SetActive(true);
	}

}
