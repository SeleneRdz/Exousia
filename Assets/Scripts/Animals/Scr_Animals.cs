using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Animals : MonoBehaviour
{
    
  public bool closeEyes;

  private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("CloseEyes", closeEyes);


        int random = UnityEngine.Random.Range(0, 600);

        if(random == 100){
            transform.localScale = new Vector3(-1,1,1);
        }

        if(random == 300){
            transform.localScale = new Vector3(1,1,1);
        }

        if(random == 500){
            closeEyes = true;
        }else{
            closeEyes = false;
        }

    }
}
