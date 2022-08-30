﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Scr_KarmaBar : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer good_guy;

    private float karma = 100f;
    private float newKarma = 100f;

    void Update(){
        if(karma > newKarma){
            karma -= 2f;
            good_guy.color = new Color (1, 1, 1, (karma/100f));
        }
        
        if(karma < newKarma){
            karma += 2f;
            good_guy.color = new Color (1, 1, 1, (karma/100f));
        }
    }
   
    // Update is called once per frame
    public void minusKarma(float amount)
    {
        newKarma = newKarma - amount;
    }

    public void moreKarma(float amount)
    {
        newKarma = newKarma + amount;
    }
}
