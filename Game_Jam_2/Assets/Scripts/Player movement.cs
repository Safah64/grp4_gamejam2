using UnityEngine;

public class Playermovement : MonoBehaviour
{
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
    

    void Start()
    {
        print(speed);
        print(jumpForce);

        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(right))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(left))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
       

        // Check if grounded
        isGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, groundDistance, groundLayer);

        if (Input.GetKeyDown(jumpKey) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        //check if crouching
        if (Input.GetKeyDown(crouchKey) && isGrounded)
        {
            crouch();
        }
      
    }

    void crouch()
    {
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y / 2, transform.localScale.z);
    }




}