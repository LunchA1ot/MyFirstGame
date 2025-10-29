using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite spr1;
    public Sprite spr2;
    int cnt = 0;
    SpriteRenderer spr;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        InvokeRepeating("Walk", 0.1f, 0.4f);
    }

    // Update is called once per frame
    void Walk()
    {
        cnt++;
        if (cnt % 2 == 0)
        {
            spr.sprite = spr1;
        }
        else
        {
            spr.sprite = spr2;
        }
    }
}
