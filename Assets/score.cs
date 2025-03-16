using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text scoreDisplay;

    public int points = 0; //Player score
    public int timePassedSeconds = 0;
    private float timer = 0; //Variable to check how much time has passed
    private float timeThreshold = 1; //Time it takes to gain another point in seconds
    private int pointGain = 1; //How many points are gained per threshold of time
    private int thirtySecond = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeThreshold)
        {
            points += pointGain;
            timer = 0;
            timePassedSeconds++;
            thirtySecond++;
            if (thirtySecond > 30)
            {
                //say "dimension up" to let the player know that something has changed 
                thirtySecond = 0;
                pointGain++;
            }
        }

        scoreDisplay.text = "Score: " + points;
    }
    public void addPoint(int pointsToAdd)
    {
        points = points + pointsToAdd;
    }
}
