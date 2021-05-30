using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MovimientoLejania : MonoBehaviour
{
    public float Velocidad;
    public GameObject personaje;
    private Vector3 posicion;
    private Vector3 reset;

    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position - personaje.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        transform.position = ((personaje.transform.position + posicion) * Velocidad);
        
        if((personaje.transform.position.x - transform.position.x) > (18.2)){

            reset = new Vector3(18.2f, 0, 0);

            transform.position += reset;

        }

        if((personaje.transform.position.x - transform.position.x) > (18.2)){

            reset = new Vector3(18.2f, 0, 0);

            transform.position += reset;

        }

        if((personaje.transform.position.x - transform.position.x) > (18.2)){

            reset = new Vector3(18.2f, 0, 0);

            transform.position += reset;

        }

        if((personaje.transform.position.x - transform.position.x) > (18.2)){

            reset = new Vector3(18.2f, 0, 0);

            transform.position += reset;

        }

        if((personaje.transform.position.x - transform.position.x) > (18.2)){

            reset = new Vector3(18.2f, 0, 0);

            transform.position += reset;

        }

        if((personaje.transform.position.x - transform.position.x) > (18.2)){

            reset = new Vector3(18.2f, 0, 0);

            transform.position += reset;

        }



   
    }

    
}
