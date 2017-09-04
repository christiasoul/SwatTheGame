using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Stores all the information that you need for a class
public class charClass : MonoBehaviour {
	private int healthTotal;
	private int healthCur;
	private int healthRegen;
	private int energyTotal;
	private int energyMax;
	private int energyRegen;

	private int con;
	private int dex;
	private int intel;

	private float moveSpeed;
	private float armor;
	private int armorLevel;

	// may need to be pulled out up a level
	enum classLabel {CHAINGUNNER, BEASTMASTER, CHEMIST, SOLDIER, MEDIC,
		ENGINEER, DRUGEE, SCIENTIST, DEMOLITION, CYBORG, TACTICIAN, TRAPPER,
		SNIPER, FLAMEGUNNER, PSYCHIC }

	enum weaponLabel {PISTOL, ASSAULT, CHAINGUN, SHOTGUN, SNIPER_RIFLE, GRENADE_LAUNCHER,
		ROCKET_LAUNCHER, FLAMETHROWER, MINE_THROWER, MAG_PISTOL, MAG_RIFLE}

	private classLabel myClass;

	private weapon myWeapon;

	private float wFireRate;
	private int wDamage;
	private int wDamageRange;
	private float wRange;
	private float wSplash;
	private float wPierce;
	private float wCritCh;
	private float wCritMul;
	private string wAmmoName;

	private float wMovePen;
	private int wMagSize;
	private float  reloadTime;


	private void healthCalc (){


	}
	private void energyCalc(){



	}
	private void resetWeapon(){
		float[] wRet = myWeapon.getWeapon();
		wFireRate = wRet [0];
		wDamage = wRet [1];
		wDamageRange = wRet [2];
		wRange = wRet [3];
		wSplash = wRet [4];
		wPierce = wRet [5];
		wCritCh = wRet [6];
		wCritMul = wRet [7];
	}




	// Use this for initialization
	void Start () {
		
	}

}
