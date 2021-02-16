using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI処理のクラスを使用する宣言
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour
{
    // Image コンポーネントを格納する変数
    private Image m_Image;
    // スプライトオブジェクトを格納する配列
    public Sprite[] m_Sprite;
    // スプライトオブジェクトを変更するためのフラグ


    // ゲーム開始時に実行する処理
    IEnumerator Start()
    {
        m_Image = GetComponent<Image>();

        m_Image.sprite = m_Sprite[0];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        m_Image = GetComponent<Image>();
        m_Image.sprite = m_Sprite[1];
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        m_Image = GetComponent<Image>();
        m_Image.sprite = m_Sprite[2];



    }
}