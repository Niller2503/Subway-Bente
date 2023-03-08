using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (scoreIncreasing)
        {
            scoreCount += transform.position.x * pointsPerSecond;
        }

        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        highScoreText.text = "High score: " + Mathf.Round( highScoreCount); 
    }
}
