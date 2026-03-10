using UnityEngine;

public class enemies : MonoBehaviour
{
    // hela gjort av Montaser

    public int health = 100;
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    public Transform playerTransform;
    public float speed = 5f;
    public float maxDistance = 8f;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    void Update()
    {

        float distance = Vector2.Distance(transform.position, playerTransform.position);

        if (distance <= maxDistance)
        {
            FollowPlayer();
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
    }

    void FollowPlayer()
    {
        Vector2 direction = (playerTransform.position - transform.position).normalized;
        rb.linearVelocity = new Vector2(direction.x * speed, rb.linearVelocity.y);
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        // Code to handle enemy death (e.g., play animation, drop loot, etc.)
        Destroy(gameObject);
    } 
  
}

