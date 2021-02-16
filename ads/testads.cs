using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class testads : MonoBehaviour
{
    private void Start()
    {
        //ゲームIDをAndroidとそれ以外(iOS)で分ける
#if UNITY_ANDROID
    string gameID = "3810449";
#else
        string gameID = "3810448";
#endif

        //広告の初期化
        Advertisement.Initialize(gameID);
    }


     public void FunctionTest()
    {

        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}