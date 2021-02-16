using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickGoal : MonoBehaviour
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
            test.SetActive(true);
            test1.SetActive(false);
        }

        if (count == 17)
        {
            //ゲームオブジェクト表示→非表示
            test.SetActive(false);
            test1.SetActive(true);
        }

    }
}
