using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Buttonchange : MonoBehaviour
{
    // 画像を動的に変えたいボタンの宣言
    Image btnImage;

    // inspectorで直接画像のスプライトを張り付ける
    public Sprite Asprite;
    public Sprite Bsprite;
    public Sprite Csprite;

    void Start()
    {
        // Imageを所得
        btnImage = this.GetComponent<Image>();
    }

    void Update()
    {
        // フラグによってそれに合った画像に差し替える
        if (Input.anyKeyDown)
        {
            btnImage.sprite = Asprite;
        }

    }
}