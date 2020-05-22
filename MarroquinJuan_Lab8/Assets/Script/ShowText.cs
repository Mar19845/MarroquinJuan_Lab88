using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }
    public void OnMouseOver() 
    {
        canvas.SetActive(true);    
    }
    public void OnMouseExit() 
    {
        canvas.SetActive(false);
    }
}
