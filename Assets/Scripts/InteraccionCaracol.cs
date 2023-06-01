using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionCaracol : MonoBehaviour
{
    public GameObject PopUpCaracol;
    public GameObject Jugador;
    public GameObject TextoCaracol;
    private bool isInteractable = false;


    void Start()
    {
        PopUpCaracol.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
            TextoCaracol.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
            TextoCaracol.SetActive(false);
        }
    }

}
