using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingSprite : MonoBehaviour
{
    public Color myColor;
    public float speed = 1.0f;
    private SpriteRenderer image;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        image = this.gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        //オブジェクトのAlpha値を更新

        image.color = GetAlphaColor(image.color);


    }
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
}
