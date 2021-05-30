using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player : MonoBehaviour
{
  public float maxSpeed = 5f;
  public float speed = 2f; 
  public bool grounded;
  public bool swimming;
  public bool moving;
  public float jumpPower = 6.5f;

  private Animator anim;
  private Rigidbody2D rb2d;
  private bool jump;
  private float H;
  private bool stop;
  private bool attack;
  public bool talk;
  private SpriteRenderer sprite;
  private bool movement = true;
  private GameObject healthbar;

    // Start is called before the first frame update
    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();
      anim = GetComponent<Animator>();
      sprite = GetComponent<SpriteRenderer>();
      healthbar = GameObject.Find("HealthBar");
    }




    void Update(){
      anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
      anim.SetBool("Grounded", grounded);
      //anim.SetBool("Swimming", swimming);
      anim.SetBool("Moving", moving);

      if(Input.GetKeyDown(KeyCode.UpArrow) && grounded){
        jump = true;
      }

      if(Input.GetKeyDown(KeyCode.O))
      {
        talk = true;
      }

      Handleinput();

    }




    private void Handleinput()
    {
      if(Input.GetKeyDown(KeyCode.P))
      {
        attack = true;
      }
    }





    private void Handleattack()
    {
      if(attack)
      {
        anim.SetTrigger("attack");
      }
    }





    private void ResetValues()
    {
      attack = false;
      talk = false;
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

      rb2d.AddForce(Vector2.right * speed * h);

      float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
      rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

      if(h > 0.1f){
        transform.localScale = new Vector3(1f, 1f, 1f);
      }

      if(h < -0.1f){
        transform.localScale = new Vector3(-1f,1f,1f);
      }

      if(jump){
        rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        jump = false;
      }

      Handleattack();
      ResetValues();

      if(!movement) h = 0;
      
    }






   public void EnemyJump()
    {
        jump = true;
    }





    public void EnemyBack(float enemyPosX)
    {
        healthbar.SendMessageUpwards("TakeDamage", 20f);

        jump = true;

        float side = Mathf.Sign(enemyPosX - transform.position.x);
        rb2d.AddForce(Vector2.left * side * jumpPower, ForceMode2D.Impulse);

        movement = false;
        Invoke("EnableMovement", 0.6f);

        sprite.color = Color.red;
    }




    
    void EnableMovement()
    {
        movement = true;
        sprite.color = Color.white;
    }

    
}
