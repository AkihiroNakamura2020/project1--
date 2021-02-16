using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager3 : MonoBehaviour
{
    [SerializeField] GameObject test;
    [SerializeField] GameObject test1;

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
        }

        if (count == 1)
        {
            //ゲームオブジェクト表示→非表示
                    }
        if (count == 2)
        {
            //ゲームオブジェクト表示→非表示
            

        }
        if (count == 3)
        {
            //ゲームオブジェクト表示→非表示

            //test2.SetActive(false);



        }
        if (count == 4)
        {
            //ゲームオブジェクト表示→非表示
            test.SetActive(false);
            test1.SetActive(false);
            

        }


    }
}

