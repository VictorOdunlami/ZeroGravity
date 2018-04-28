using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocCollision : MonoBehaviour {

    public RocketMovement movement;  

         void OnCollisionEnter(Collision collisionInfo)
         {

            if (collisionInfo.collider.tag == "obstacle")
            {

            movement.enabled = true;

            }

         }
    
    

}