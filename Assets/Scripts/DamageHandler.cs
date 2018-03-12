using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

    int health;
    float shipBoundaryRadius = 0.35f;
    Vector3 position;
    public GameObject GameOverCanvas;
    GameObject meteorFinishLine;
    Score scorescript;

    // Use this for initialization

    void Start () {
        health = 1;
        
        meteorFinishLine = GameObject.Find("MeteorFinishLine");
        scorescript = meteorFinishLine.GetComponent<Score>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        position = transform.position;

        if (health == 0)
            killPlayer();

        outOfBounds();
    }

    void recievePlayerCollision()
    {
        health = 0;
    }

    void outOfBounds()
    {
        if (position.y + shipBoundaryRadius > Camera.main.orthographicSize)
        {
            killPlayer();
           
        }
        if (position.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        {
            killPlayer();
        }
    }

    void killPlayer()
    {
        PlayerPrefs.SetInt("currentScore", scorescript.score);
        if (scorescript.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scorescript.score);
            PlayGamesScript.AddScoreToLeaderboard(GPGSIds.leaderboard_leaderboard, scorescript.score);
           
        }
        scorescript.enabled = false;

        GameOverCanvas.SetActive(true);

        Destroy(gameObject);
       

    }
}
