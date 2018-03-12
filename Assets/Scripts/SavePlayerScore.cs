using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayerScore : MonoBehaviour
{
    GameObject meteorFinishLine;
    Score scorescript;
	// Use this for initialization

	void Start ()
    {
        meteorFinishLine = GameObject.Find("MeteorFinishLine");
        scorescript = meteorFinishLine.GetComponent<Score>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(scorescript.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scorescript.score);
        }
	}
}
