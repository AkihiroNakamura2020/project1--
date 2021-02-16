using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{

    bool left = false;
    bool right = false;
    bool up = false;
    bool down = false;

    // Start is called before the first frame update
    void Start()
    {
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        if (left)
        {

            myTransform.Translate(-1.0f, 0, 0, Space.World);
            bool left = false;
        }


        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            bool left = true;
        }

        if (right)
        {
            myTransform.Translate(1.0f, 0, 0, Space.World);
            bool right = false;
        }

        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            bool right = true;
        }


        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            bool up = true;
        }

        if (up)
        {
            myTransform.Translate(0, 0, 1.0f, Space.World);
            bool up = false;

        }

        // 後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            bool down = true;
        }

        if (down)
        {
            myTransform.Translate(0, 0, -1.0f, Space.World);
            bool down = false;
        }
    }
}
