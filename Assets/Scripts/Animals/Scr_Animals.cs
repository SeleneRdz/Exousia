using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Animals : MonoBehaviour
{
    private Animator animation;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        random = UnityEngine.Random.Range(0, 600);
        
        turnLeft(random);
        turnRight(random);
        closeEyes(random);
    }

    //-------------------------------------FUNCTIONS----------------------------------

    private void turnLeft(int random)
    {
        //If the random is 100 the animal turn to left
        if(random == 100){
            transform.localScale = new Vector3(-1,1,1);
        }
    }

    private void turnRight(int random)
    {
        //If the random is 300 the animal turn to right
        if(random == 300){
            transform.localScale = new Vector3(1,1,1);
        }
    } 

    private void closeEyes(int random)
    {
        bool closeEyes;
        
        if(random == 500){
            closeEyes = true;
        }
        else{
            closeEyes = false;
        }

        //The animal close eyes or open
        animation.SetBool("CloseEyes", closeEyes);
    }
}
