using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLuz : MonoBehaviour
{
    
    public Light luz;
    void OnTriggerEnter(Collider other) 
    {
        luz.enabled = true;
    }
    
    void OnTriggerExit(Collider other)
    {
        luz.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        luz.intensity= Mathf.Sin(Time.time * 10)*100;
    }

}
