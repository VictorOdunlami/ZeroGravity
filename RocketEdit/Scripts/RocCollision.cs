
using UnityEngine;

public class RocCollision : MonoBehaviour {

    public RocketMovement movement;  

         void OnCollisionEnter(Collision collisionInfo)
         {

            if (collisionInfo.collider.tag == "Rings")
            {

				movement.enabled = false;

            }

         }
    
    

}