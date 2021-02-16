using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStatus : MonoBehaviour
{
	// Start is called before the first frame update
	Button buttonA;


	// Use this for initialization
	void Start()
	{
		buttonA = GameObject.Find("Buttonsam").GetComponent<Button>();
		
	}

	// Update is called once per frame
	void Update()
	{
        if (Input.GetKeyDown("space"))
		{
			//buttonA.enabled = false;
			buttonA.interactable = false;
		}

		if (Input.GetKeyDown("a"))
		{
			//buttonA.enabled = true;
			buttonA.interactable = true;
		}

	}
}
