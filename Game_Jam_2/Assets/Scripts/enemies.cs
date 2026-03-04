using UnityEngine;

public class enemies : MonoBehaviour
{
    public int health = 100;
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.linearVelocity = new Vector2(direction.x, direction.y).normalized * force;
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
