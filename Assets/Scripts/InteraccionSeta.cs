using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionSeta : MonoBehaviour
{ 
    public GameObject PopUpSeta;
    public GameObject Jugador;
    public GameObject TextoSeta;
    private bool isInteractable = false;


    void Start()
    {
        PopUpSeta.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
            TextoSeta.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
            TextoSeta.SetActive(false);
        }
    }

}
