using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPointManager : MonoBehaviour
{
	[SerializeField] UnityEngine.UI.Text textbox;

	public int point_num;

	void Start()
	{
		point_num = PlayerPrefs.GetInt("CPoint", 2);

		//text = textbox.GetComponent<Text>().text;

		textbox.text = point_num.ToString();


	}

	void Update()
    {
		point_num = PlayerPrefs.GetInt("CPoint", 2);
		textbox.text = point_num.ToString();

	}

}
