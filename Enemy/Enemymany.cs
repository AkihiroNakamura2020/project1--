using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymany : MonoBehaviour
{
    [SerializeField] GameObject fire1;
    [SerializeField] GameObject fire2;
    [SerializeField] GameObject fire3;
    [SerializeField] GameObject fire4;
    [SerializeField] GameObject fire5;
    [SerializeField] GameObject fire6;

    int count = 0;


    void Update()
    {

        if (Input.anyKeyDown)
        {
            count++;
        }


        if (count == 0)
        {
            //ゲームオブジェクト表示→非表示
            fire1.SetActive(true);
            fire2.SetActive(true);
            fire3.SetActive(true);
            fire4.SetActive(true);
            fire5.SetActive(true);
            fire6.SetActive(true);
        }

        if (count == 3)
        {
            //ゲームオブジェクト表示→非表示
            fire1.SetActive(false);
            fire2.SetActive(false);
            fire3.SetActive(false);
            fire4.SetActive(false);
            fire5.SetActive(false);
            fire6.SetActive(false);
        }

        if (count == 6)
        {
            count = 0;
        }
    }
}
