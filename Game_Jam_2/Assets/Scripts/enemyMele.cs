using Unity.VisualScripting;
using UnityEngine;

public class enemyMele : MonoBehaviour
{
    // hela gjort av Montaser

    public Playermovement player;   // reference to  player script
    public float attackRange = 1.5f;
    public int damage = 10;
    public float attackCooldown = 1f;

    private float lastAttackTime;

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance <= attackRange && Time.time >= lastAttackTime + attackCooldown)
        {
            Attack();
        }
    }

    void Attack()
    {
        lastAttackTime = Time.time;

        // Call the player's damage function
        player.takeDamage(damage);

        Debug.Log("Enemy attacked player!");
    }

}
