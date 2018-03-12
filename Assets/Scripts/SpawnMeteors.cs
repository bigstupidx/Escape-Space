using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteors : MonoBehaviour
{

    GameObject smallMeteor;
    // A timer variable that holds the amount of time it will take for a meteor to spawn
    float timer;

    float meteorPosition_x;

    // Min and Max spawning positions in the y axis.
    float max_y;
    float min_y;

    // Will use the score variable to alter the spawning time of the meteors.
    int score;
    int amountOfMeteorsToSpawn;


    void Start()
    {
        timer = 0.0f;

        amountOfMeteorsToSpawn = 3;

        smallMeteor = Resources.Load("Meteors/MeteorSmall") as GameObject;

        // Right outside camera range.
        meteorPosition_x = 16.0f;

        // Max and min spawning position of meteors in the y axis.
        max_y = 2.95f;
        min_y = -2.95f;
    }

    void Update()
    {

        timer -= Time.deltaTime;

        meteorSpawnTiming();
    }

    // spawns meteor(s) each time the value of timer hits 0.
    void meteorSpawnTiming()
    {
        if (timer <= 0f)
        {
            spawnMeteor();

            timer = 1.0f;

             if(score >= 20)
            {
                amountOfMeteorsToSpawn = 4;
            }
            

            if (score >= 60)
            {
                timer = 0.8f;
            }
                
            if(score >= 150)
            {
                amountOfMeteorsToSpawn = 5;
            }

            if(score >= 200)
            {
                timer = 0.7f;
            }

            if(score >= 300)
            {
                amountOfMeteorsToSpawn = 6;
            }
               
                
        }
    }

    // Spawns a meteor
    void spawnMeteor()
    {

        GameObject go;


        float b = 0;

        float spawn_y;
        float prev_y = 0f;
        for(int i = 0; i < amountOfMeteorsToSpawn; i++)
        {
            spawn_y = Random.Range(min_y, max_y);
           

            //if (Mathf.Abs(spawn_y - prev_y) < 0.8f)
            //{

            //    Debug.Log("smaller");
            //    //if (spawn_y >= max_y - 0.5f)
            //    //{
            //    //    spawn_y = spawn_y - 0.8f;
            //    //}
            //    //else if (spawn_y <= -min_y + 0.5f)
            //    //{
            //    //    spawn_y = spawn_y + 0.8f;
            //    //}
               
                    
            //        if(spawn_y < prev_y)
            //        {
            //            spawn_y = spawn_y - (0.8f - Mathf.Abs(spawn_y - prev_y));
            //            Debug.Log("smaller");
            //        }
            //        else
            //        {
            //            spawn_y = spawn_y + (0.8f - Mathf.Abs(spawn_y - prev_y));
            //            Debug.Log("bigger");
            //        }
                
            //}
            
            go = Instantiate(smallMeteor, new Vector3(meteorPosition_x + b, spawn_y, -1), Quaternion.identity);
            b+=1.0f;
            go.transform.SetParent(transform, false);
          
            prev_y = spawn_y;
        }

        b = 0;
      

    }

    void recievedScore(int score)
    {
        this.score = score;
    }
}
