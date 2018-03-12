using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorAcceleration : MonoBehaviour {

    public float meteorSpeed;
    public Vector3 meteorPosition;

    GameObject meteorFinishLine;
    Score scoreScript;

    int previousScore;
    float speedIncreaseIncrement;

    
    void Start()
    {
        meteorFinishLine = GameObject.Find("MeteorFinishLine");
        scoreScript = meteorFinishLine.GetComponent<Score>();
        

        previousScore = 0;
        speedIncreaseIncrement = 0.02f;

    }

    void Update()
    {
        
        if (scoreScript.score > previousScore)
        {
            if (scoreScript.score >= 200 && scoreScript.score <= 300)
                speedIncreaseIncrement = 0.01f;

            meteorSpeed += (scoreScript.score - previousScore) * speedIncreaseIncrement;
            


            previousScore = scoreScript.score;

            transform.BroadcastMessage("recieveMeteorSpeed", meteorSpeed);
            gameObject.SendMessage("recievedScore", scoreScript.score);
            
        }


    }
}
