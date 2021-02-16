using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    Animator animator;


    void Start()
    {
        this.animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetTrigger("Go");
        }

        if (Input.GetKeyDown("a"))
        {
            animator.SetTrigger("Back");
        }
    }
}
