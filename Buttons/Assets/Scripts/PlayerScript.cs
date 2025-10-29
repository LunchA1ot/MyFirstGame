using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
        Rigidbody2D rb;
        float InHorizontal;
        float x;
        int jumps;
        public float jumpForce;
       
        void Start()
        {
        rb = GetComponent<Rigidbody2D>();
        x = gameObject.transform.localScale.x;
        }

    // Update is called once per frame
    void Update()
    {
        InHorizontal = Input.GetAxis("Horizontal");

        if (gameObject.transform.position.x < -20 || gameObject.transform.position.x > 20 || gameObject.transform.position.y < -7 || gameObject.transform.position.y > 7)
          {
          SceneManager.LoadScene("Scene2");
          }
        if (InHorizontal != 0)
          {
            rb.velocity = new Vector2(InHorizontal * 10, rb.velocity.y);
            if (InHorizontal < 0)
            {
                gameObject.transform.localScale = new Vector3(1 * x, gameObject.transform.localScale.y, 1);
            }
            else
            {
                gameObject.transform.localScale = new Vector3(-1 * x, gameObject.transform.localScale.y, 1);
            }
        }
        if (Input.GetButtonDown("Jump") && jumps > 0)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            jumps = jumps - 1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        jumps = 1;
    }

}

