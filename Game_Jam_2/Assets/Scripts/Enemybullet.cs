using UnityEngine;

public class Enemybullet : MonoBehaviour
{
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
        Debug.Log(distance);
        if (distance < 4)
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
