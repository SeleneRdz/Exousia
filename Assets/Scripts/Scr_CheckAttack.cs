using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_CheckAttack : MonoBehaviour
{

    private Scr_Player player;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Scr_Player>();
    }

    void FixedUpdate(){
        float h = Input.GetAxis("Fire1");

        if(h != 0){
            player.attacking = true;
        }else
        {
            player.attacking = false;
        }
    }

    
}
