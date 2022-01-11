using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scr_Aparicion : MonoBehaviour
{
    public AudioSource SonidoRelampago;
    private Animator anim;
    private bool active = true;


    // Start is called before the first frame update
    void Start()
    {
        SonidoRelampago = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();


    }

    private void ReproducirSonido(){
        SonidoRelampago.Play();



    }

    private void ActiveIsFalse(){
        active = false;
    }
    
    void Update(){
        anim.SetBool("Active", active);
    }

}
