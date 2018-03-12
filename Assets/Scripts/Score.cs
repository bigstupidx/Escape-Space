using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {


    public int score;

    void Start ()
    {

    }
	
    // Message sent from script "FinishLineCollision". Each time a rock collides
    // with the finish line. Add +1 to the score.

    void recieveFinishLineDetection()
    {
        score++;
    }
}
