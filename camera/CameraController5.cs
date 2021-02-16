using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController5 : MonoBehaviour
{
    //CameraController4の改変前のもの

    public GameObject mainCam;
    public GameObject subCam;
    public GameObject HPBarCtrl;
    public GameObject Button;

    Button btn;

    void Start()
    {
        mainCam.SetActive(true);
        subCam.SetActive(false);
        HPBarCtrl.SetActive(false);

        btn = Button.GetComponent<Button>();
    }

    public void Pushsky()
    {
        StartCoroutine("Pushcam");

    }



    IEnumerator Pushcam()
    {

        mainCam.SetActive(!mainCam.activeSelf);
        subCam.SetActive(!subCam.activeSelf);
        HPBarCtrl.SetActive(!HPBarCtrl.activeSelf);

        yield return new WaitForSeconds(3);

        mainCam.SetActive(!mainCam.activeSelf);
        subCam.SetActive(!subCam.activeSelf);
        HPBarCtrl.SetActive(!HPBarCtrl.activeSelf);
        btn.interactable = false;

        yield return new WaitForSeconds(3);
        btn.interactable = true;
    }
}
