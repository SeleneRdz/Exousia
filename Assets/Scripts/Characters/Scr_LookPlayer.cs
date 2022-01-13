using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_LookPlayer : MonoBehaviour
{
    public GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float characterPosition = transform.position.x;
        float playerPosition = personaje.transform.position.x;

        if(playerPosition < characterPosition){
            transform.localScale = new Vector3(-1f,1f,1f);
        }

        if(playerPosition > characterPosition){
            transform.localScale = new Vector3(1f,1f,1f);
        }
    }
}
