﻿
using UnityEngine;

public class camFollow : MonoBehaviour {

    public Transform rocket;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = rocket.position + offset;

	}
}
