using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Animals : MonoBehaviour
{
    private Animator anim;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
        if(random == 100)
        {
            //The animal turn to left
            transform.localScale = new Vector3(-1,1,1);
        }
    }

    private void turnRight(int random)
    {
        if(random == 300)
        {
            //The animal turn to right
            transform.localScale = new Vector3(1,1,1);
        }
    } 

    private void closeEyes(int random)
    {
        bool closeEyes;
        
        if(random == 500)
        {
            closeEyes = true;
        }
        else
        {
            closeEyes = false;
        }

        //The animal close eyes or open
        anim.SetBool("CloseEyes", closeEyes);
    }
}
