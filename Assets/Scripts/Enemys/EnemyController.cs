using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
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

    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 target = initialPosition;
        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < visionRadius) target = player.transform.position;

        float fixedSpeed = speed * Time.deltaTime;
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
        float enemyPosition = transform.position.y;
        float playerPosition = collision.transform.position.y;

        if(collision.gameObject.CompareTag("Player"))
        {
            if (enemyPosition < playerPosition)
            {
                float yOffset = 0.5f;
                if (enemyPosition + yOffset < playerPosition)
                {
                    collision.SendMessage("EnemyJump");
                    Destroy(gameObject);
                }
                else
                {
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
