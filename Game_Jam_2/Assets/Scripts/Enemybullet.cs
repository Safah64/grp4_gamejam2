using UnityEngine;

public class Enemybullet : MonoBehaviour
{
    // hela gjort av Montaser

    public GameObject enemyBullet;
    public Transform bulletPos;
    private GameObject player;

    private float timer;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
       
      

        float distance = Vector2.Distance(transform.position, player.transform.position);
       
        if (distance < 10)
        {
            timer += Time.deltaTime;
            if (timer >= 2f)
            {

                timer = 0f;
                shoot();
            }
        }


    }


    void shoot()
    {
        Instantiate(enemyBullet, bulletPos.position, Quaternion.identity);
    }
}
