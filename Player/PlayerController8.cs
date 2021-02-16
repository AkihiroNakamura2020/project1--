using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController8 : MonoBehaviour
{
    [SerializeField]//インスペクターにpublicではない変数を表示させる属性

    Vector3[] wallPoses = new Vector3[] {
        new Vector3(0, 0, 3.0f),
        new Vector3(0, 0, 6.0f),
        new Vector3(8.0f, 0, 3.0f),
        };



    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 nextPosition = transform.position;//同じ処理はまとめたほうがコンパクト
            nextPosition.x = Mathf.Clamp(nextPosition.x - 1, 0, 10);
            transform.LookAt(nextPosition);
            bool hit = false;//障害物があるかどうかのフラグ

            foreach (Vector3 v in wallPoses)
            {
                if (v == nextPosition)
                {
                    hit = true;
                    break;
                }
            }

            if (!hit)
            {
                transform.position = nextPosition;
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 nextPosition = transform.position;//同じ処理はまとめたほうがコンパクト
            nextPosition.x = Mathf.Clamp(nextPosition.x + 1, 0, 10);
            transform.LookAt(nextPosition);
            bool hit = false;//障害物があるかどうかのフラグ

            foreach (Vector3 v in wallPoses)
            {
                if (v == nextPosition)
                {
                    hit = true;
                    break;
                }
            }

            if (!hit)
            {
                transform.position = nextPosition;
            }

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 nextPosition = transform.position;//同じ処理はまとめたほうがコンパクト
            nextPosition.z = Mathf.Clamp(nextPosition.z + 1, 0, 10);
            transform.LookAt(nextPosition);
            bool hit = false;//障害物があるかどうかのフラグ

            foreach (Vector3 v in wallPoses)
            {
                if (v == nextPosition)
                {
                    hit = true;
                    break;
                }
            }

            if (!hit)
            {
                transform.position = nextPosition;
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 nextPosition = transform.position;//同じ処理はまとめたほうがコンパクト
            nextPosition.z = Mathf.Clamp(nextPosition.z - 1, 0, 10);
            transform.LookAt(nextPosition);
            bool hit = false;//障害物があるかどうかのフラグ

            foreach (Vector3 v in wallPoses)
            {
                if (v == nextPosition)
                {
                    hit = true;
                    break;
                }
            }

            if (!hit)
            {
                transform.position = nextPosition;
            }

        }
    }


    public void PushLeftButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = Mathf.Clamp(nextPosition.x - 1, 0, 10.0f);
        this.transform.LookAt(nextPosition);
        bool hit = false;//障害物があるかどうかのフラグ

        foreach (Vector3 v in wallPoses)
        {
            if (v == nextPosition)
            {
                hit = true;
                break;
            }
        }

        if (!hit)
        {
            transform.position = nextPosition;
        }
    }
    public void PushRightButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = Mathf.Clamp(nextPosition.x + 1, 0, 9.0f);
        this.transform.LookAt(nextPosition);
        bool hit = false;//障害物があるかどうかのフラグ
        foreach (Vector3 v in wallPoses)
        {
            if (v == nextPosition)
            {
                hit = true;
                break;
            }
        }

        if (!hit)
        {
            transform.position = nextPosition;
        }



    }
    public void PushUpButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z = Mathf.Clamp(nextPosition.z + 1, 0, 9.0f);
        this.transform.LookAt(nextPosition);
        bool hit = false;//障害物があるかどうかのフラグ

        foreach (Vector3 v in wallPoses)
        {
            if (v == nextPosition)
            {
                hit = true;
                break;
            }
        }

        if (!hit)
        {
            transform.position = nextPosition;
        }
    }
    public void PushDownButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z = Mathf.Clamp(nextPosition.z - 1, 0, 10.0f);
        this.transform.LookAt(nextPosition);
        bool hit = false;//障害物があるかどうかのフラグ

        foreach (Vector3 v in wallPoses)
        {
            if (v == nextPosition)
            {
                hit = true;
                break;
            }
        }

        if (!hit)
        {
            transform.position = nextPosition;
        }
    }
}
