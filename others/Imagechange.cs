using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Imagechange : MonoBehaviour
{

    public Image image;
    private Sprite sprite;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            sprite = Resources.Load<Sprite>("2");
            image = this.GetComponent<Image>();
            image.sprite = sprite;
        }
    }
}