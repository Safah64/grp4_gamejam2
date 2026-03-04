using UnityEngine;

public class enemies : MonoBehaviour
{
    public int health = 100;
   




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
