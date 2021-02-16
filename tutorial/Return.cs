using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int b = 0;
        b = aaa(b);
        b = aaa(b);
        b = aaa(b);
        Debug.Log(b);


    }

    int aaa(int b)
    {
        return ++b;
    }
}
