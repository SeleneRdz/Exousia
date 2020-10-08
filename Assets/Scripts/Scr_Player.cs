using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
  public int vida;
  public Vector3 posicion;
  public float velocidad; 
  Animator personajeAnim;

    // Start is called before the first frame update
    void Start()
    {
      personajeAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      float MoverLateral = Input.GetAxisRaw("Horizontal");
      float MoverHorizontal = Input.GetAxisRaw("Vertical");
      
      posicion = new Vector3(MoverLateral, MoverHorizontal, 0);
      posicion = posicion.normalized;
      transform.position += posicion * velocidad * Time.deltaTime;
      personajeAnim.SetFloat("VelMovimiento", Mathf.Abs(MoverLateral));


      if(MoverLateral <= -1){
        transform.localScale = new Vector3(-1, 1, 1);
      }
      if(MoverLateral >= 1){
        transform.localScale = new Vector3(1, 1, 1);
      }
    }
}
