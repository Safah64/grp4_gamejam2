using UnityEngine;

public class Playermovement : MonoBehaviour
{
   [SerializeField] private float speed = 5f;
   [SerializeField] KeyCode right = KeyCode.D;
   [SerializeField] KeyCode left = KeyCode.A;
    void Start()
    {
        print(speed);
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
    }
}
