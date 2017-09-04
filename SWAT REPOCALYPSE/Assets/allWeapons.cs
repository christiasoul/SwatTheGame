using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allWeapons : MonoBehaviour {
	private weapon[] weaponList;
	// Use this for initialization
	void Start () {
		
	}

	public weapon getWeapon(int weapNum){
		return weapon[weapNum];
	}
	

}
