using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour {

    Vector3 position;

    float max_x;
    float min_x;

    float speed = 1.0f;

    bool MoveRight = true;

	// Use this for initialization
	void Awake () {
        position = transform.position;
   
        max_x = 11.5f;
        min_x = 4.0f;
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        if(MoveRight)
        {
            position.x += speed * Time.deltaTime;
        }
        else
        {
            position.x -= speed * Time.deltaTime;
        }

        if(position.x >= max_x)
        {
            MoveRight = false;
        }
        else if(position.x <= min_x)
        {
            MoveRight = true;
        }

        transform.position = position;
	}
}
