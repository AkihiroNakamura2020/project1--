using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem particle;


    void Start()
    {
        particle = this.GetComponent<ParticleSystem>();
     

    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            particle.Play();
            Debug.Log("Hit");

        }
    }

}