using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ExampleClass : MonoBehaviour
{
    public Color myColor;
    private Image image;


    void Start()
    {
        image = GetComponent<Image>();
    }

    // The mesh goes red when the mouse is over it...
    void OnMouseEnter()
    {
        image.color = Color.red;
    }

    // ...the red fades out to cyan as the mouse is held over...
    void OnMouseOver()
    {
        image.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        image.color = Color.white;
    }
}