using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class admanager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject openb;
    [SerializeField] GameObject closeb;

    public int point_num;


    void Start()
    {
        panel.SetActive(false);
        closeb.SetActive(false);
    }

    void Update()
    {

    }

    public void PushAd()
    {
        StartCoroutine("Pushadmanage");

    }

    IEnumerator Pushadmanage()
    {
        panel.SetActive(true);

        yield return new WaitForSeconds(3);

        closeb.SetActive(true);


    }

    public void PushAdclose()
    {
        panel.SetActive(false);
        closeb.SetActive(false);

        point_num = PlayerPrefs.GetInt("CPoint", 2);
        point_num = point_num + 10;

        PlayerPrefs.SetInt("CPoint", point_num);
        PlayerPrefs.Save();
        //PlayerPrefs.DeleteKey("CPoint");        //CPointのデータのみ初期化
    }



}
