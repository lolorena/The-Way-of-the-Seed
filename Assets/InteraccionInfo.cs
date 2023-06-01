using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionInfo : MonoBehaviour
{
    public GameObject PopUpInfo;
    public GameObject Jugador;
    public GameObject TextoInfo;
    private bool isInteractable = false;


    void Start()
    {
        PopUpInfo.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = true;
            TextoInfo.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInteractable = false;
            TextoInfo.SetActive(false);
        }
    }

}