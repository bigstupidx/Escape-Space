using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBackgroundMovement : MonoBehaviour {

   

    public float backgroundSpeed;

    void Start()
    {
        
    }


    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= backgroundSpeed * Time.deltaTime;

        transform.position = pos;
    }
}
