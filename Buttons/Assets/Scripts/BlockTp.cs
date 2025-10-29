using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTp : MonoBehaviour
{ 
    public int tps;
    public float interval;
    int n;

    void Start()
    {
        n = tps;
        InvokeRepeating("recharge", 10f, interval * 1f);
    }

    void recharge()
    {
        if (n < tps)
        {
        n = tps;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy" && n > 0)
        {
            float x = collision.gameObject.transform.position.x - 40;
            float y = collision.gameObject.transform.position.y;
            float z = collision.gameObject.transform.position.z;

            collision.gameObject.transform.position = new Vector3(x, y, z);
            n--;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
