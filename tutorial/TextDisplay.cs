using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplay : MonoBehaviour
{
    [SerializeField] GameObject test;

    void Update()
    {
        //[D]キーを押す
        if (Input.GetKeyDown(KeyCode.D))
        {
            //ゲームオブジェクト表示→非表示
            test.SetActive(true);
        }

    }

}