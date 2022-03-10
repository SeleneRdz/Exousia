﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_EnemyController : MonoBehaviour
{
    public float visionRadius;
    public float speed;
    private GameObject healthbarenemy;
    public Rigidbody2D rb2d;
    public float jumpPower;
    private bool jump;
    private SpriteRenderer sprite;
    private bool movement = true;
    GameObject player;
    float fixedSpeed;

    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        fixedSpeed = speed * Time.deltaTime;

        player = GameObject.FindGameObjectWithTag("Player");
        target = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance < visionRadius) target = player.transform.position;
        
        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

        Debug.DrawLine(transform.position, target, Color.red);

    }

     void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float enemyPosition     = transform.position.y;
        float playerPosition    = collision.transform.position.y;
        float yOffset           = 0.5f;

        if(collision.gameObject.CompareTag("Player")){
            if (enemyPosition < playerPosition){
                if (enemyPosition + yOffset < playerPosition){
                    collision.SendMessage("EnemyJump");
                    Destroy(gameObject);
                }
                else{
                    collision.SendMessage("EnemyBack", transform.position.x);
                }
            }
        }
    }

    public void EnemyJump()
    {
        jump = true;
    }

    public void EnemyBack(float enemyPosX)
    {

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
