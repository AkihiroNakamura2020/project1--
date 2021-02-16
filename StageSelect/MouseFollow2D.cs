using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MouseFollow2D : MonoBehaviour
{
    private Vector3 position;
    private Vector3 screenToWorldPointPosition;

    private void Update()
    {
        // Vector3でマウス位置座標を取得する
        position = Input.mousePosition;

        position.z = 30f;

        // マウス位置座標をスクリーン座標からワールド座標に変換する
        screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);

        // ワールド座標に変換されたマウス座標を代入
        gameObject.transform.position = screenToWorldPointPosition;
    }
}
