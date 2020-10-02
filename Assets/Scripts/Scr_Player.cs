using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
  public int vida;
  public Vector3 posicion;
  public float velocidad; 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      
      posicion = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
      posicion = posicion.normalized;
      transform.position += posicion * velocidad * Time.deltaTime;
    }
}
