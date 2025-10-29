using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose : MonoBehaviour
{
    // Start is called before the first frame update
    public int lifes;
    private int score;
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            lifes--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ( lifes <= 0 )
        {
            score = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("bestscore", score);
            SceneManager.LoadScene("Scene2");
        }
    }
}
