using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletKill2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", 5f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
    }
        // Update is called once per frame
    void Update()
    {
        
    }
}
