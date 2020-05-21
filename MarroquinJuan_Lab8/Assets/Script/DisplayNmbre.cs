using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNmbre : MonoBehaviour
{
      // Start is called before the first frame update
    public Text txt;
    public string myString;
    public float fadeTime;
    public bool displayInfo;
    void Start()
    {

        txt = GameObject.FindGameObjectWithTag("objeto").GetComponent<Text>();
        txt.color = Color.clear;

    }

    // Update is called once per frame
    void Update()
    {

        FadeText();

        if (Input.GetKeyDown(KeyCode.Escape))
            Screen.lockCursor = false;

    }



    public void OnMouseOver()
    {
        displayInfo = true;
    }

    public void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText() 
    {

        if (displayInfo)
        {

            txt.text = myString;
            txt.color = Color.Lerp(txt.color, Color.red, fadeTime * Time.deltaTime);
        
        }
        else 
        {

            txt.color = Color.Lerp(txt.color, Color.clear, fadeTime * Time.deltaTime); 

        }

    }
}
