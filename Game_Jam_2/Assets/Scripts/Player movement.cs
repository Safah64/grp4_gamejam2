using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] KeyCode right = KeyCode.D;
    [SerializeField] KeyCode left = KeyCode.A;
    [SerializeField] KeyCode jump = KeyCode.Space;
    void Start()
    {
        print(speed);
        print(jumpForce);
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
        if (Input.GetKey(jump))
        {
            transform.Translate(Vector3.up * jumpForce * Time.deltaTime);
        }
    }
}
