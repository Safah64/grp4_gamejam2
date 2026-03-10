using UnityEngine;

public class wepon : MonoBehaviour
{
    // hela gjort av Montaser

    public Transform firepoint;
    
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            bullet.transform.right = transform.right * transform.localScale.x; // Set the bullet's right direction to match the weapon's right direction
           
        }
    }



}
