using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderRef : MonoBehaviour
{
    Slider hpSlider;

    void Start()
    {

        hpSlider = GetComponent<Slider>();
    }

    void Update()
    {
        if (hpSlider.value ==0 )
        {
            hpSlider.value = 1;
        }  
    }
}
