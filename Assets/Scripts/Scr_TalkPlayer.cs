using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_TalkPlayer : MonoBehaviour
{
    
    public float visionRadius;
    private Scr_Player player;
    private bool talking;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<Scr_Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate(){
        talking = player.talk; // No jala no copia el valor de scr_player

        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < visionRadius && talking){
            Debug.Log(dist);                    //hace falta añadir que el cuadro de dialogo aparezca
        }

    }

     void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}
