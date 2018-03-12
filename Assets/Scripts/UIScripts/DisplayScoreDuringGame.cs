using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreDuringGame : MonoBehaviour {

    GameObject meteorFinishLine;
    Score scoreScript;
    int previousScore;
    public Text scoreText;
	// Use this for initialization

	void Start ()
    {
        meteorFinishLine = GameObject.Find("MeteorFinishLine");
        scoreScript = meteorFinishLine.GetComponent<Score>();

        previousScore = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (scoreScript.score > previousScore)
        {
            scoreText.text = "SCORE: " + scoreScript.score;
            previousScore = scoreScript.score;
        }
           
	}
}
