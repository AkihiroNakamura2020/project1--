using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Wall : MonoBehaviour
{
    private GameObject player;   //プレイヤー情報格納用

    Vector3 pos;
    Vector3 playerpos;

    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用 


    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("Player");
        mainCamera = GameObject.Find("MainCamera");
        subCamera = GameObject.Find("SubCamera");

    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        playerpos = this.player.transform.position;

        if (pos == playerpos)
        {
            subCamera.transform.SetParent(null);
            Destroy(player);

            Invoke("Over", 0.0f);

        }

    }
    
    void Over()
    {
        
        SceneManager.LoadScene("GameOver");
    }
}
