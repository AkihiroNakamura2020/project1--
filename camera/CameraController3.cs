using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController3 : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject subCam;

    void Start()
    {
        mainCam.SetActive(true);
        subCam.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCam.SetActive(!mainCam.activeSelf);
            subCam.SetActive(!subCam.activeSelf);
        }
    }

    public void Pushsky()
    {
        mainCam.SetActive(!mainCam.activeSelf);
        subCam.SetActive(!subCam.activeSelf);
    }
}
