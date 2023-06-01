using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionPuerta : MonoBehaviour
{
    public GameObject PopUpPuerta;
    public GameObject Jugador;
    public GameObject TextoPuerta;
    private bool isInteractable = false;


    void Start()
    {
        PopUpPuerta.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
            TextoPuerta.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
            TextoPuerta.SetActive(false);
        }
    }

}
