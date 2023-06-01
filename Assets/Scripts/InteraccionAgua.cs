using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionAgua : MonoBehaviour
{
    public GameObject PopUpAgua;
    public GameObject Jugador;
    public GameObject TextoAgua;
    private bool isInteractable = false;


    void Start()
    {
        PopUpAgua.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
            TextoAgua.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
            TextoAgua.SetActive(false);
        }
    }

}
