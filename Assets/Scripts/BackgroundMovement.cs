using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    GameObject MeteorHandler;
    MeteorAcceleration meteorScript;

    public float backgroundSpeed;
    GameObject meteorFinishLine;
    Score scoreScript;

    public float speedIncreaseIncrement;
    int previousScore;
    void Start ()
    {
        previousScore = 0;
        MeteorHandler = GameObject.Find("MeteorHandler");
        meteorScript = MeteorHandler.GetComponent<MeteorAcceleration>();
        speedIncreaseIncrement = 0.02f;
        meteorFinishLine = GameObject.Find("MeteorFinishLine");
        scoreScript = meteorFinishLine.GetComponent<Score>();
    }
	
	
	void Update ()
    {
        if(scoreScript.score > previousScore)
        {

            if (scoreScript.score >= 200 && scoreScript.score <= 300)
                speedIncreaseIncrement = 0.01f;

            backgroundSpeed += (scoreScript.score - previousScore) * speedIncreaseIncrement;
            

            previousScore = scoreScript.score;
        }

        Vector3 pos = transform.position;
        pos.x -= backgroundSpeed * Time.deltaTime;

        transform.position = pos;
	}
}
