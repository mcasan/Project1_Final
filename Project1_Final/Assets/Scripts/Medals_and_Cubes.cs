using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medals_and_Cubes : MonoBehaviour {

	int silver; 
	int bronze;
	int gold;
	int miningSpeed;
	int TimetoMine;
	int bronzeSupply;
	int silverSupply;
	int Xposition;
	public GameObject cube;

	// Use this for initialization
	void Start () {

	miningSpeed = 3;

	silver = 0;

	bronze = 0;
	
	bronzeSupply = 4;

	silverSupply = 2;

	TimetoMine = miningSpeed;

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time >= TimetoMine) {

			TimetoMine = TimetoMine + miningSpeed;


			if (bronzeSupply > 0) {
				

				bronze = bronze + 1;

				bronzeSupply = bronzeSupply - 1;

				print (bronze + " bronze");

				var mycube = Instantiate (cube, new Vector3 (Random.Range (-6, 9), Random.Range (-4, 4)), Quaternion.identity);

				mycube.GetComponent<Renderer> ().material.color = Color.red;

				mycube.GetComponent<Click> ().Medal_Type = "bronze";






								   } 

			else if (bronzeSupply == 0) {
				

				if (silverSupply > 0) {
					
					
					silver = silver + 1;

					silverSupply = silverSupply - 1;

					print (silver + " silver");

					var mycube = Instantiate (cube, new Vector3 (Random.Range (-6, 9), Random.Range (-4, 4)), Quaternion.identity);

					mycube.GetComponent<Renderer> ().material.color = Color.white;

					mycube.GetComponent<Click> ().Medal_Type = "silver";



				}
			}



			else if (bronze == 2 && silver == 2) {
				
			
				gold = gold + 1;		

				print ( gold + " gold" );

				var mycube = Instantiate (cube, new Vector3 (Random.Range (-6, 9), Random.Range (-4, 4)), Quaternion.identity);
			
				mycube.GetComponent<Renderer> ().material.color = Color.yellow;

				mycube.GetComponent<Click> ().Medal_Type = "gold";
												 }

		    }

		
				   }

}
