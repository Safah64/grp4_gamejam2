using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // hela gjort av Montaser
    public float speed = 20f;
    public int damage = 35;
    public Rigidbody2D rb;
    private float timer;
    void Start()
    {
        rb.linearVelocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        enemies enemy = hitInfo.GetComponent<enemies>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    void Update()
        {
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                Destroy(gameObject);
            }
    }
}
