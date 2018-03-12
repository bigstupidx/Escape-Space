using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMeteor : MonoBehaviour {

    Vector3 position;

    float meteorSpeed;

	// Use this for initialization
	void Start ()
    {
        meteorSpeed = this.transform.parent.GetComponent<MeteorAcceleration>().meteorSpeed;
        position = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        position.x -= meteorSpeed * Time.deltaTime;

        transform.position = position;
    }

    void recieveMeteorSpeed(float meteorSpeed)
    {
        this.meteorSpeed = meteorSpeed;
    }
}
