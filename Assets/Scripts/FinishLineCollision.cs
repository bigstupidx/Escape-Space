using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Message recieved by script "Score".
        gameObject.SendMessage("recieveFinishLineDetection");
        if(collision.gameObject.name[0] == 'M')
        {
            Destroy(collision.gameObject);
        }
        
       // Destroy(collision.gameObject.transform.parent.gameObject);
       
    }
}
