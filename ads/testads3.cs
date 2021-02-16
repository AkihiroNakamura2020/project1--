using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class testads3 : MonoBehaviour
{
    public int point_num;

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


    public void ShowRewardedAd()
    {
        Debug.Log(Advertisement.IsReady());

        if (Advertisement.IsReady("rewardedVideo"))
        {
            ShowOptions options = new ShowOptions
            {
                resultCallback = Result
            };
            Advertisement.Show("rewardedVideo", options);
        }
    }

    private void Result(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("広告表示成功");
                // ここで報酬をユーザーに付与する

                point_num = PlayerPrefs.GetInt("CPoint", 2);
                point_num += 1;

                PlayerPrefs.SetInt("CPoint", point_num);
                PlayerPrefs.Save();
                //PlayerPrefs.DeleteKey("CPoint");        //CPointのデータのみ初期化


                break;
            case ShowResult.Skipped:
                Debug.Log("スキップされました");
                break;
            case ShowResult.Failed:
                Debug.LogError("失敗しました。");
                break;
        }
    }
}