using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medals_and_Cubes : MonoBehaviour {


	float miningSpeed;
	float TimetoMine;
	public static int points, bronzePoints, silverPoints, goldPoints;
	public static int bronze, silver, gold;
	public GameObject cubePrep;
	Ore recentOre;
	GameObject mycube;
		
		
	// Use this for initialization
	void Start () {
		
	miningSpeed = 3;

	silver = 0;

	bronze = 0;
	
	bronzePoints = 1;

	silverPoints = 10;

	goldPoints = 100;

	recentOre = Ore.Bronze;

	TimetoMine = miningSpeed;

	
	}

	public static void ProcessClickedCube (Ore ore) {
		
		if (ore == Ore.Bronze) {
			bronze--;
			points += bronzePoints;

		} else if (ore == Ore.Silver) {
			silver--;
			points += silverPoints;

		} else {
			gold--;
			points += goldPoints;

		}


	}

	void SpawCube (Ore ore) {
		
		Color cubeColor;

		if (ore == Ore.Bronze) {

			cubeColor = Color.red;
		} 
			
		else if (ore == Ore.Silver) {

			cubeColor = Color.white;
		}
		else {

			cubeColor = Color.yellow;
		}



		var mycube = Instantiate (cubePrep, new Vector3 (Random.Range (-6, 9), Random.Range (-4, 4)), Quaternion.identity);
		mycube.GetComponent<Renderer> ().material.color = cubeColor;
		mycube.GetComponent<Click> ().myOre = ore;

	
	}    		


	// Update is called once per frame
	void Update () {

	

		if (Time.time >= TimetoMine) {

			TimetoMine = TimetoMine + miningSpeed;



			if (bronze == 2 && silver == 2 && recentOre != Ore.Gold) {

				gold = gold + 1;		

				SpawCube (Ore.Gold);

			
			}


			else if (bronze < 4) {

				bronze = bronze + 1;
			
				SpawCube (Ore.Bronze);




			} 


			else {	

				silver = silver + 1;

				SpawCube (Ore.Silver);

			}

			print ("Total Points: " + points);

		    }

		
				 }

}
