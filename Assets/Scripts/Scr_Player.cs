using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
  public float maxSpeed = 5f;
  public float speed = 2f; 
  public bool grounded;
  public bool moving;
  public float jumpPower = 6.5f;

  private Animator anim;
  private Rigidbody2D rb2d;
  private bool jump;
  private float H;
  private bool stop;

    // Start is called before the first frame update
    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();
    }


    void Update(){
      anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
      anim.SetBool("Grounded", grounded);
      anim.SetBool("Moving", moving);

      if(Input.GetKeyDown(KeyCode.UpArrow) && grounded){
        jump = true;
      }
    }

    void FixedUpdate(){

      Vector3 fixedVelocity = rb2d.velocity;
      fixedVelocity.x *= 0.9f;
      float h = Input.GetAxis("Horizontal");

      if(grounded && (Mathf.Abs(h) < Mathf.Abs(H))){
        rb2d.velocity = fixedVelocity;
      }

      if(grounded && Mathf.Abs(h) <= 0.1 && Mathf.Abs(H) >= 0.1 ){
        rb2d.velocity *= 0.2f;
      }



      H = h;
      Debug.Log(h);


      
      rb2d.AddForce(Vector2.right * speed * h);

      float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
      rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

      if(h > 0.1f){
        transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
      }

      if(h < -0.1f){
        transform.localScale = new Vector3(-0.7f,0.7f,0.7f);
      }

      if(jump){
        rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        jump = false;
      }

      
    }
}
