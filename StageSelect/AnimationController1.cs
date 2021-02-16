using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController1 : MonoBehaviour
{
    public GameObject obj;
    Animator anim;


    void Start()
    {
        obj = GameObject.Find("Imagefollow");
        anim = obj.GetComponent<Animator>();
    }


    void OnMouseEnter()
    {
        anim.SetTrigger("Back");
    }
}
