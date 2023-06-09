using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreperSec : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "Score : " + (int)scoreAmount;
        scoreAmount = scoreAmount + pointIncreasedPerSecond * Time.deltaTime;
    }
}
