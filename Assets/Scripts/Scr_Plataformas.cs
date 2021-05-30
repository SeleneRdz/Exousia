using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Plataformas : MonoBehaviour
{

    private PlatformEffector2D effector;
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.DownArrow)){
            waitTime = 0.5f;
        }
        
        if(Input.GetKey(KeyCode.DownArrow)){
            if(waitTime <= 0){
                effector.rotationalOffset = 180f;
                waitTime = 0.5f;
            } else {
                waitTime -= Time.deltaTime;
            }
        }

        
        if(Input.GetKey(KeyCode.UpArrow)){
            effector.rotationalOffset = 0;
        }
    }
}
