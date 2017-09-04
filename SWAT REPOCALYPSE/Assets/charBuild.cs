using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charBuild : MonoBehaviour {

	private traitAction [] possibleTraits = new traitAction[10];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private interface traitAction{
		void doAction (character targ);
	}
	private class traits{

		string traitName;


	}



}

