using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilObjetivo : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.name == "puente") //Si el objeto que colisiona es un puente
        {
            GameObject nadadoresPadre =  GameObject.Find("SpawnerBulbosNAD");

            FollowTarget[] allChildren = nadadoresPadre.GetComponentsInChildren<FollowTarget>();
            foreach (FollowTarget child in allChildren)
            {
                child.irAObjectivo(other.gameObject);
            }
        }

    }

}