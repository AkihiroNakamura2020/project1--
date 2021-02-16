using UnityEngine;
using UnityEngine.Advertisements;//Advertisementクラスを使うのに必要

public class testads2 : MonoBehaviour
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

    private void Update()
    {
        //広告が使えるようになったかの確認
        Debug.Log(Advertisement.IsReady());
    }

}