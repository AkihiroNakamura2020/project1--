using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMove : MonoBehaviour
{
    void Update()
    {

        // transformを取得
        Transform myTransform = this.transform;
        // 現在の座標からのxyz を1ずつ加算して移動
        myTransform.Translate(0.01f, 0.01f, 0.01f);
    }
}
