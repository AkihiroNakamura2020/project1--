using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FlameP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnParticleCollision(GameObject obj)
    {
        Debug.Log("何かと衝突しました");

        if (obj.tag == "Player")
        {
            Debug.Log("敵と衝突しました");
            SceneManager.LoadScene("GameOver");

        }
    }

}
