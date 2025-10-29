using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public float time;
    private float timeStart;

    void Start()
    {
        timeStart = time;
    }

    void Update()
    {
        PlayerPrefs.SetInt("score", score);
        time -= Time.deltaTime;
        scoreText.text = "Time: " + score;
        if (time <= 0)
        {
            score += 1;
            time = timeStart;
        }
    }
}