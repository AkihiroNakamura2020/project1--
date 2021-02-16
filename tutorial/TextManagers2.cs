using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManagers2 : MonoBehaviour
{
    [SerializeField] GameObject test;
    [SerializeField] GameObject test1;
    [SerializeField] GameObject test2;
    [SerializeField] GameObject test3;
    [SerializeField] GameObject test4;

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
            test.SetActive(true);
        }

        
        if (count == 3)
        {
            //ゲームオブジェクト表示→非表示

           //test2.SetActive(false);
           test.SetActive(false);
        }


        
        if (count == 4)
        {
            //ゲームオブジェクト表示→非表示
            test.SetActive(false);
            test3.SetActive(false);
            test4.SetActive(false);

        }


    }
}

