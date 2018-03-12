using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {


    public Text highScoreText;
    public Text currentScoreText;

	// Use this for initialization
	void Start ()
    {
        currentScoreText.text = "SCORE \n\n"  + PlayerPrefs.GetInt("currentScore");
        highScoreText.text = "HIGHSCORE \n\n" + PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
