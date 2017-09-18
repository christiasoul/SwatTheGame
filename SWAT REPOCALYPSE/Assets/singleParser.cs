using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class singleParser : MonoBehaviour {
	private static bool canProgress = true;

	private const string weapFileName = "weaponList.txt";
	private const int numOfWeapons = 4;
	private const int numOfWeapLines = 20;

	// Use this for initialization
	void Start () {
		if (canProgress) {
			canProgress = false;

		}
	}

	weaponInfo [] ReadWeaponFile(){
		try{
			StreamReader weapFile = new StreamReader (weapFileName);

			weaponInfo [] myWeaponAry = new weaponInfo[numOfWeapons];
			string curString;

			for (int i = 0; i < numOfWeapons; i++) {
				curString = weapFile.ReadLine().Split(",");
			}
		}
		catch (FileNotFoundException e){

		}


	}

	// Update is called once per frame
	void Update () {
		
	}
}
