using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{

    private List<int> myList = new List<int>(); //Listの宣言
    private float timeleft; //時間測定のための変数
    private int count; //カウント変数

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            myList.Add(i); //int型 iをmyList末尾に加える
        }
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            timeleft = 1.0f;
            this.GetComponent<Text>().text = myList[9 - count].ToString(); //テキストの変更
            count++;
        }
    }
}