using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPBarctrl : MonoBehaviour
{

    Slider _slider;
    float _hp = 3;
    private float timeleft;

    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();

    }

    void OnDisable()
    {
        _hp = 3;

    }


    void Update()
    {
        timeleft = Time.deltaTime;

        _hp -= timeleft;

        // HPゲージに値を設定

        _slider.value = _hp;

        if (_hp <= 0)
        {

            _hp = 0;
        }
    }

    //void OnEnable()
   
}