using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("ChangeColor1");
    }

    IEnumerator ChangeColor1()
    {

        //赤色にする
        gameObject.GetComponent<Renderer>().material.color = Color.red;

        //1秒停止
        yield return new WaitForSeconds(1);

        //もう一つのコルーチンを実行する
        StartCoroutine("ChangeColor2");

    }

    IEnumerator ChangeColor2()
    {

        //青色にする
        gameObject.GetComponent<Renderer>().material.color = Color.blue;

        //1秒停止
        yield return new WaitForSeconds(1);

        //黄色にする
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;

    }

}