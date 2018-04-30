﻿
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
	public float upforce = 500f;

	// Use this for initialization
	void Start () {

       rb.useGravity = false;  

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
		///
		if (Input.GetKey("w") )
		{
			rb.AddForce(0, upforce * Time.deltaTime, 0,ForceMode.VelocityChange);
		}
		
		if (Input.GetKey("s") )
		{
			rb.AddForce(0, -upforce * Time.deltaTime, 0,ForceMode.VelocityChange);
		}

    }
}
   