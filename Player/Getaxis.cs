using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getaxis : MonoBehaviour
{
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");
        transform.Translate(dx, dy, 0.0F);
    }
}
