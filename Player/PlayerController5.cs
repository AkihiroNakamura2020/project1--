using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController5 : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 nextPosition = transform.position;
            nextPosition.x = Mathf.Clamp(nextPosition.x - 1, 0, 10.0f);
            this.transform.LookAt(nextPosition);
            
            transform.position = nextPosition;
            
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 nextPosition = transform.position;
            nextPosition.x = Mathf.Clamp(nextPosition.x + 1, 0, 9.0f);
            this.transform.LookAt(nextPosition);
            transform.position = nextPosition;
           

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 nextPosition = transform.position;
            nextPosition.z = Mathf.Clamp(nextPosition.z + 1, 0, 9.0f);
            this.transform.LookAt(nextPosition);

            
                transform.position = nextPosition;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 nextPosition = transform.position;
            nextPosition.z = Mathf.Clamp(nextPosition.z - 1, 0, 10.0f);
            this.transform.LookAt(nextPosition);

            transform.position = nextPosition;
        }

    }
    public void PushLeftButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = Mathf.Clamp(nextPosition.x - 1, 0, 10.0f);
        this.transform.LookAt(nextPosition);
        transform.position = nextPosition;
    }
    public void PushRightButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.x = Mathf.Clamp(nextPosition.x + 1, 0, 9.0f);
        this.transform.LookAt(nextPosition);
        transform.position = nextPosition;
       
    }
    public void PushUpButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z = Mathf.Clamp(nextPosition.z + 1, 0, 9.0f);
        this.transform.LookAt(nextPosition);
        transform.position = nextPosition;
    }
    public void PushDownButton()
    {
        Vector3 nextPosition = transform.position;
        nextPosition.z = Mathf.Clamp(nextPosition.z - 1, 0, 10.0f);
        this.transform.LookAt(nextPosition);
        transform.position = nextPosition;
    }

}
