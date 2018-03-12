using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        // This only picks up collisions with meteors.
        if(collision.gameObject.name[0] == 'M')
        {
            gameObject.SendMessage("recievePlayerCollision");
            
        }

    }
}
