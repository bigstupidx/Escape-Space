using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    GameObject MeteorHandler;
    MeteorAcceleration meteorScript;
    public AudioSource shipSoundEffect;
    float playerSpeed;
    public Vector3 playerPosition;
    bool movingUp = false;

    float playerMaxSpeed = 5f;
    float playerMinSpeed = 1f;
    float acceleration = 0.01f;

    // Use this for initialization
    void Start()
    {
        MeteorHandler = GameObject.Find("MeteorHandler");
        meteorScript = MeteorHandler.GetComponent<MeteorAcceleration>();

        playerSpeed = playerMinSpeed;

        playerPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 18.0f, Screen.height / 2.0f, 10));

    }
    

    void Update()
    {
        //// Mobile Input
        //foreach (Touch touch in Input.touches)
        //{
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        playerSpeed = playerMinSpeed;
        //        movingUp = true;
        //        shipSoundEffect.Play();
        //    }
        //    if (touch.phase == TouchPhase.Ended)
        //    {
        //        playerSpeed = playerMinSpeed;
        //        movingUp = false;
        //        shipSoundEffect.Stop();
        //    }
        //}


        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerSpeed = playerMinSpeed;
            movingUp = true;
            shipSoundEffect.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            playerSpeed = playerMinSpeed;
            movingUp = false;
            shipSoundEffect.Stop();
        }

        if (movingUp)
        {

            playerSpeed += acceleration * meteorScript.meteorSpeed;
            if (playerSpeed >= playerMaxSpeed)
                playerSpeed = playerMaxSpeed;

            playerPosition.y += playerSpeed * Time.deltaTime;


        }
        else if(!movingUp)
        {
            playerSpeed += acceleration * meteorScript.meteorSpeed;
            if (playerSpeed >= playerMaxSpeed)
                playerSpeed = playerMaxSpeed;

            playerPosition.y -= playerSpeed * Time.deltaTime;
        }

       
        transform.position = playerPosition;
    }

  
}
