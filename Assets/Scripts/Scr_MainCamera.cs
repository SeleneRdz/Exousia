using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_MainCamera : MonoBehaviour
{
    public float x;
    public GameObject personaje;
    private Vector3 posicion;

    // Start is called before the first frame update
    void Start()
    {
        posicion = transform.position - personaje.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = personaje.transform.position + posicion;
        /*
         x += Time.deltaTime * Input.GetAxisRaw("Mouse Y") * 100    ;
         transform.rotation = Quaternion.Euler(x,0,0);
         transform.position = new Vector3(0,x/10,(x/10)-10);
         */
         
    }

}
