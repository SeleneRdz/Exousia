using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Fadeout : MonoBehaviour
{
    private SpriteRenderer renderer;
    private float counter = 1;
    private float newCounter = 1;
    public bool AutoActive;
    public GameObject Structure;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter > newCounter){
            Debug.Log(counter);
            counter -= 0.02f;
            renderer.color = new Color (1, 1, 1, counter); 
        }
        
        if(counter < newCounter){
            Debug.Log(counter);
            counter += 0.02f;
            renderer.color = new Color (1, 1, 1, counter); 
        }
    }

    void OnTriggerStay2D(Collider2D col){

        
        if(col.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.W) || AutoActive)){
            // Change the 'color' property of the 'Sprite Renderer'
            newCounter = 0;
            Structure.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col){

        if(col.gameObject.tag == "Player"){
            // Change the 'color' property of the 'Sprite Renderer'
            newCounter = 1;
            Structure.SetActive(false);
        }
    }
       
}
