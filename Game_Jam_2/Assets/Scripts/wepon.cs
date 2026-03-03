using UnityEngine;

public class wepon : MonoBehaviour
{
    private Playermovement playerMovement;


    public Transform firepointRight;
    public Transform firepointLeft;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (playerMovement.transform.localScale.x > 0)
            {
                shootRight();
            }
            else
            {
                shootLeft();
            }
        }
    }


void shootRight()
    {
        //shooting logic
        Instantiate(bulletPrefab, firepointRight.position, firepointRight.rotation);  
    }
void shootLeft()
    {
        //shooting logic
        Instantiate(bulletPrefab, firepointLeft.position, firepointLeft.rotation);  
    }
}
