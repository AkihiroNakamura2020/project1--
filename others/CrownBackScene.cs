using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CrownBackScene : MonoBehaviour
{


  public void PushCrownBack()
    {
        int nowlevel = PlayerPrefs.GetInt("nowLEVEL", 0);

        if (nowlevel == 0)
        {
            SceneManager.LoadScene("StageSelect");
        }
        if (nowlevel == 1)
        {
            SceneManager.LoadScene("StageSelecthard");
        }
        if (nowlevel == 2)
        {
            SceneManager.LoadScene("StageSelecthell");
        }

    }
}
