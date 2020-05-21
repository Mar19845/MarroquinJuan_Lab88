using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarLuz : MonoBehaviour
{
    // Start is called before the first frame update
    public Light luz;
    void OnTriggerEnter(Collider other) 
    {
        luz.enabled = true;
    }
    
    void OnTriggerExit(Collider other)
    {
        luz.enabled = false;
    }
}
