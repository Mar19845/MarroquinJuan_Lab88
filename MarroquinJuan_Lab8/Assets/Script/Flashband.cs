using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashband : MonoBehaviour
{
    private float maxEnergy;
    public float max;
    private int batteries;
    private float currentEnergy;
    public GameObject flashLight;
    public GameObject lightobj;
    private bool flashEne;
    private float usedEnergy;
    //public float restaEnergia;
    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        maxEnergy = 50* batteries;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // energia maxima
        maxEnergy = 50* batteries;
        currentEnergy = maxEnergy;
        if(Input.GetMouseButtonDown(0))
        {
            flashEne =! flashEne;
            //sound.Play();

        }
        if(flashEne)
        {
            flashLight.SetActive(true);
            sound.Play();
            
            // si es menor a 0 apagar el lightobj
            if(currentEnergy <= 0)
            {
                lightobj.SetActive(false);
            }
            // si la bateria es mayor a 0 encender el lightobj
            if(currentEnergy > 0)
            {
                lightobj.SetActive(true);
                // descargo de la bateria
                currentEnergy -= 10 * Time.deltaTime;
                usedEnergy +=  10 * Time.deltaTime;
            }
            if(usedEnergy >= 50)
            {
                batteries -=1;
                usedEnergy = 0;
            }

        }
        else
        {
            flashLight.SetActive(false);
            sound.Play();
        }
    }
    // funcion que recoge las baterias
    public void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Bateria"))
        {
            batteries +=1;
            Destroy(other.gameObject);
        }
    }
}
