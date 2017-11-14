using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public Ore myOre;


	/// Use this for initilization 
	void Start () {



	}


	/// Update is called once per frame
	void Update () {



	}

	void OnMouseDown (){
		

		Destroy (gameObject);

		Medals_and_Cubes.ProcessClickedCube (myOre);


	}


}
