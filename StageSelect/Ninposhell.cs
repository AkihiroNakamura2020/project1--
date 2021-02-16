using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ninposhell : MonoBehaviour
{
    [SerializeField] GameObject nin1;
    [SerializeField] GameObject nin2;
    [SerializeField] GameObject nin3;
    [SerializeField] GameObject nin4;
    [SerializeField] GameObject nin5;
    [SerializeField] GameObject nin6;

    public int playstage;




    void Start()
    {
        int playstage = PlayerPrefs.GetInt("playstage", 1);

        int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);

        if (nowlevel == 2)
        {
            if (playstage == 1)
            {
                nin1.SetActive(true);

            }
            if (playstage == 2)
            {
                nin2.SetActive(true);

            }
            if (playstage == 3)
            {
                nin3.SetActive(true);
            }
            if (playstage == 4)
            {
                nin4.SetActive(true);
            }
            if (playstage == 5)
            {
                nin5.SetActive(true);
            }
            if (playstage == 6)
            {
                nin6.SetActive(true);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayStage(int No)
    {

        PlayerPrefs.SetInt("playstage", No);

    }
}
