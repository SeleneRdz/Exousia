﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_CheckGrounded : MonoBehaviour
{

    private Scr_Player player;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Scr_Player>();
    }

    void OnCollisionStay2D(Collision2D col){
        if(col.gameObject.tag == "Ground"){
            player.grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D col){
        if(col.gameObject.tag == "Ground"){
            player.grounded = false;
        }
    }
}