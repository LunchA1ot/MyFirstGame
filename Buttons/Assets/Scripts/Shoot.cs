using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet1;
    public GameObject bullet2;
    Vector3 shootV;
    public int bullets;
    public float interval;
    public int bullets2;
    public float interval2;
    int n;
    int n2;

    void Start()
    {
        n = bullets;
        n2 = bullets2;
        InvokeRepeating("recharge1", 10f, interval * 1f);
        InvokeRepeating("recharge2", 30f, interval2 * 1f);
    }

    void recharge1()
    {
        if (n == 0)
        {
            n += bullets;
        }
    }

    void recharge2()
    {
        if (n2 == 0)
        {
            n2 += bullets2;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2") && n2 > 0)
        {
            shootV = new Vector3(Input.mousePosition.x - 400, Input.mousePosition.y - 150, 0);
            GameObject bulletspawned = Instantiate(bullet2,
                gameObject.transform.position,
                gameObject.transform.rotation);
            bulletspawned.GetComponent<Rigidbody2D>().velocity = shootV / 25;
            n2--;
        }
            if (Input.GetButtonDown("Fire1") && n > 0)
        {
            shootV = new Vector3(Input.mousePosition.x - 400, Input.mousePosition.y - 100, 0);
            GameObject bulletspawned = Instantiate(bullet1, 
                gameObject.transform.position, 
                gameObject.transform.rotation);
            bulletspawned.GetComponent<Rigidbody2D>().velocity = shootV / 25;
            n--;
        }
    }
}
