using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip sonidoDespertar;
    public AudioClip sonidoMandarUbi;
    private AudioSource hiloMusical;
    void Start()
    {
        hiloMusical = GetComponent<AudioSource>();
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();
    }

    void Update()
    {
        
    }
}
