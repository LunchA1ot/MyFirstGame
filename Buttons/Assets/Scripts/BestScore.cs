using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    void Start()
    {
        score = PlayerPrefs.GetInt("bestscore");
        scoreText.text = "" + score;
    }
}
