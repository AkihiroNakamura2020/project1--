using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerhell: MonoBehaviour
{
    [SerializeField]//インスペクターにpublicではない変数を表示させる属性

    Vector3[] wallPoses = new Vector3[] {
     
        new Vector3(0, 0, 6.0f),
        };

    Animator anim;

    // Update is called once per frame

    void Update()
    {
        Vector3 nextPosition = transform.position;//同じ処理はまとめたほうがコンパクト
        anim = GetComponent<Animator>();


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            nextPosition.x = Mathf.Clamp(nextPosition.x - 1, 0, 10);
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            nextPosition.x = Mathf.Clamp(nextPosition.x + 1, 0, 9);
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            nextPosition.z = Mathf.Clamp(nextPosition.z + 1, 0, 9);
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            nextPosition.z = Mathf.Clamp(nextPosition.z - 1, 0, 10);
            anim.SetTrigger("Run");
        }



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

    public void PushLeftButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = Mathf.Clamp(nextPosition.x - 1, 0, 10);
        anim = GetComponent<Animator>();
        anim.SetTrigger("Run");



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
    public void PushRightButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = Mathf.Clamp(nextPosition.x + 1, 0, 9);
        anim = GetComponent<Animator>();
        anim.SetTrigger("Run");



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
    public void PushUpButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z = Mathf.Clamp(nextPosition.z + 1, 0, 9);
        anim = GetComponent<Animator>();
        anim.SetTrigger("Run");



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
    public void PushDownButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z = Mathf.Clamp(nextPosition.z - 1, 0, 10);
        anim = GetComponent<Animator>();
        anim.SetTrigger("Run");



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
