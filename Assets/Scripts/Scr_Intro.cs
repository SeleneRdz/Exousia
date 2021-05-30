using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_Intro : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(anim.GetCurrentAnimatorStateInfo(0).IsName("Escena_intro"));
        if(!anim.GetCurrentAnimatorStateInfo(0).IsName("Escena_intro")){
            SceneManager.LoadScene("Menu");
        }
    }
}
