using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall2 : MonoBehaviour
{
    private GameObject player;   //プレイヤー情報格納用

    Vector3 pos;
    Vector3 playerpos;
    

    private GameObject mainCamera;      //メインカメラ格納用
    private GameObject subCamera;       //サブカメラ格納用

    Ray ray;
    RaycastHit hit;


    // Use this for initialization
    void Start()
    {
        this.player = GameObject.Find("Wall");

    }

    // Update is called once per frame
    void Update()
    {
        
        pos = transform.position;
        playerpos = this.player.transform.position;
        //Vector3 startpos = new Vector3(0, 0, 0);

        if (pos == playerpos)
        {
            playerpos = new Vector3(0, 0, 0); 
            
        }

    }

}


