using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.transform.localScale = new Vector3(-1 * gameObject.transform.localScale.x, gameObject.transform.localScale.y, 1);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}