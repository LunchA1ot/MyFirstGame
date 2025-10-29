using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class BlockMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    int U_d = 1;
    float y;
    void Start()
    {
        y = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, speed * U_d, 0);

        if (gameObject.transform.position.y <= y)
        {
            U_d = 1;
        }
        if (gameObject.transform.position.y >= -y)
        {
            U_d = -1;
        }
    }
}
