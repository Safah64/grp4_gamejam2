using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Playermovement : MonoBehaviour
{
    // hela gjort av Montaser

    [SerializeField] private float speed = 5f;
    [SerializeField] KeyCode right = KeyCode.D;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode jumpKey = KeyCode.Space;
    [SerializeField] KeyCode crouchKey = KeyCode.S;

    public float jumpForce = 5f;
    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundLayer;
    
    private Rigidbody2D rb;
    private bool isGrounded;

    float standingSize;
    float crouchingSize;
    
    public int maxhealth = 100;
    public int currentHealth;

    public healthBarScript healthBar;
    public restartScreen gameOverMenu;

    [SerializeField] private Animator animator;
    void Start()
    {
        standingSize = transform.localScale.y;
        crouchingSize = standingSize / 2;
        print(speed);
        print(jumpForce);

        rb = GetComponent<Rigidbody2D>();

        currentHealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKey(left))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }

        // Determine whether the player is moving (keyboard keys or horizontal axis)
        bool isMoving = Input.GetKey(right) || Input.GetKey(left) || Mathf.Abs(Input.GetAxisRaw("Horizontal")) > 0f;
       

        // Check if grounded
        RaycastHit2D hit = Physics2D.Raycast(groundCheck.position, Vector2.down, groundDistance, groundLayer);
        isGrounded = hit.collider != null;

        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            jump();
        }

        //check if crouching
        if (Input.GetKeyDown(crouchKey) && isGrounded)
        {
            crouch(); 
        }
        else if (Input.GetKeyUp(crouchKey))
        {
            transform.localScale = new Vector3(transform.localScale.x, standingSize, transform.localScale.z);
        }
    }
       
    void crouch()
    {
        transform.localScale = new Vector3(transform.localScale.x, crouchingSize, transform.localScale.z);
    }
    void jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    // made public and PascalCase so other scripts can call it
    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
           
        }
    }

    void Die()
    {
        gameOverMenu.ShowGameOver();
       
    }
}