using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectChildCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
       
        if(coll.gameObject.name[0] == 'P')
        {
            gameObject.SendMessageUpwards("recieveChildCollisionMessage", gameObject.name);
        }
       
    }
}
