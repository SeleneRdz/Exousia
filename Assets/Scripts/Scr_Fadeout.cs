using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Fadeout : MonoBehaviour
{
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void OnTriggerStay2D(Collider2D col){

        if(col.gameObject.tag == "Player"){
            // Change the 'color' property of the 'Sprite Renderer'
            renderer.color = new Color (255, 255, 255, 0); 
        }
    }

    void OnTriggerExit2D(Collider2D col){

        if(col.gameObject.tag == "Player"){
            // Change the 'color' property of the 'Sprite Renderer'
            renderer.color = new Color (255, 255, 255, 255); 
        }
    }
       
}
