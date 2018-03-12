using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBackground : MonoBehaviour
{

    GameObject purpleSpace1;
    GameObject purpleSpace2;
    GameObject purpleSpace3;

    float pos_x = -10f;
    // The most recent child that has collided with the player
    string recentChildCollision;

    void Start()
    {
        purpleSpace1 = GameObject.Find("purpleSpace1");
        purpleSpace2 = GameObject.Find("purpleSpace2");
        purpleSpace3 = GameObject.Find("purpleSpace3");
    }

    void Update()
    {

        if (purpleSpace2.transform.position.x <= pos_x)
        {
            BoxCollider2D collider = purpleSpace1.GetComponent<BoxCollider2D>();
            Vector3 pos = purpleSpace2.transform.position;
            pos.x += (collider.size.x * 2.0f) * 2.8f;
            purpleSpace2.transform.position = pos;

        }

        if (purpleSpace3.transform.position.x <= pos_x)
        {
            BoxCollider2D collider = purpleSpace1.GetComponent<BoxCollider2D>();
            Vector3 pos = purpleSpace3.transform.position;
            pos.x += (collider.size.x * 2.0f) * 2.8f;
            purpleSpace3.transform.position = pos;
        }

        if (purpleSpace1.transform.position.x <= pos_x)
        {

            BoxCollider2D collider = purpleSpace1.GetComponent<BoxCollider2D>();
            Vector3 pos = purpleSpace1.transform.position;
            pos.x += (collider.size.x * 2.0f) * 2.8f;
            purpleSpace1.transform.position = pos;

        }
    }
}
