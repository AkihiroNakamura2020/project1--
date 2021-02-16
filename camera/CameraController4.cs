using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController4 : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject subCam;
    public GameObject HPBarCtrl;
    public GameObject Button;

    Button btn;

    public int point_num; // スコア変数

    void Start()
    {
        mainCam.SetActive(true);
        subCam.SetActive(false);
        HPBarCtrl.SetActive(false);

        btn = Button.GetComponent<Button>();

        //PlayerPrefs.DeleteKey("CPoint");        //CPointのデータのみ初期化

        point_num = PlayerPrefs.GetInt("CPoint", 2);
        

    }

    public void Pushsky()
    {
        StartCoroutine("Pushcam");

    }



    IEnumerator Pushcam()
    {
        point_num = PlayerPrefs.GetInt("CPoint", 2);
        Debug.Log(point_num);


        if (point_num > 0)
        {
            point_num -= 1;
            //Debug.Log(point_num);

            PlayerPrefs.SetInt("CPoint", point_num);
            PlayerPrefs.Save();

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
}
