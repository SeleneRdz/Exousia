using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_Fuente : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionStay2D(Collision2D col){
        if(col.gameObject.tag == "Teleport"){
            SceneManager.LoadScene("Nivel1");
        }
    }
}
