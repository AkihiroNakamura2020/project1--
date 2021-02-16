using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -1);
        }

    }
    public void PushLeftButton()
    {
        transform.Translate(-1, 0, 0);
    }
    public void PushRightButton()
    {
        transform.Translate(1, 0, 0);
    }
    public void PushUpButton()
    {
        transform.Translate(0, 0, 1);
    }
    public void PushDownButton()
    {
        transform.Translate(0, 0, -1);
    }


}
