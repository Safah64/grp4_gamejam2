using UnityEngine;

public class fallDeath : MonoBehaviour
{
    // hela gjort av Montaser
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Playermovement player = collision.GetComponent<Playermovement>();

            if (player != null)
            {
                player.takeDamage(9999); // instantly kills player
            }
        }
    }
}
