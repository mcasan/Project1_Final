using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Here is to control time  & Print "it has been 3 seconds" 

public class ControlObject : MonoBehaviour {

	bool readyToPrint;

	// Use this for initialization 
	void Start () {

		print ("The game has begun!");

		readyToPrint = true;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= 3 && readyToPrint) {
			
			print ("It has been three seconds!");
			readyToPrint = false;
		
		}
		
	}
}
