using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponHeld{
	private float fireRate;
	private float damage;
	private float damageRange;
	private float range;
	private float splash;
	private float pierce;
	private float critChance;
	private float critMult;
	private float ammoUse;
	private float otherStat;
	private float [] weaponProgression; // [ammo][each stat]

	private string ammoName;
	private float movePenalty;
	private int magSize;
	private float reloadTime;
	private float windUpTime;
	private float followThroughTime;

	private int weaponID;

	public weaponHeld(float [] inputAry, string inAmmoName, int [] intAry, float [] inWeapProg){
		fireRate = inputAry [0];
		damage  = inputAry [0];
		damageRange  = inputAry [0];
		range = inputAry [0];
		splash = inputAry [0];
		pierce = inputAry [0];
		critChance = inputAry [0];
		critMult = inputAry [0];
		ammoUse = inputAry [0];
		otherStat = inputAry [0];
		movePenalty = inputAry [0];
		reloadTime = inputAry [0];
		windUpTime = inputAry [0];
		followThroughTime = inputAry [0];

		ammoName = inAmmoName;
		magSize = intAry [0];
		weaponID = intAry [1];

		weaponProgression = inWeapProg;


	}

	// returns [0] as the crit damage, and [1] as the unmodified damage
	public float [] GetDamageCrit(){
		float tempDamage = new float[2];

		tempDamage[0] = damage + Random.Range (0, damageRange);

		if (Random.value > critChance) {
			tempDamage [1] = tempDamage [0] * critMult;
		} else {
			tempDamage [1] = tempDamage [0];
		}

		return tempDamage;
	}

	public int GetWeapID(){return weaponID;}
	public float GetDType(){}
	public float GetDamage(){return damage;}
	public float GetDamageRange(){return damageRange;}
	public float GetRange(){return range;}
	public float GetSplash(){return splash;}
	public float GetPierce(){return pierce;}
	public float GetFireRate(){return fireRate;}
	public float GetReloadTime(){return reloadTime;}
	public float GetWindUpTime(){return windUpTime;}
	public float GetFollowThroughTime(){return followThroughTime;}


}

public class rifle_Attack : attack{

	public rifle_Attack(ref weaponHeld setWeapon){
		myWeapon = setWeapon;
	}

	public override int GetAimType (){
		return (int)aimType.HITSCAN;
	}

	public override bool Activate ()
	{
		// May need to have cursor create a target object on cursor to target
		cursorController.Get.ChangeCursorGraphic (1);
	}

	// May limit splash number
	public override bool Use (target setTarget)
	{
		if (myWeapon.GetSplash > 0) {
			float[] damageAry = myWeapon.GetDamageCrit ();
			setTarget.DealDamage (damageAry [0], myWeapon.GetDType, true);
			Collider[] overlappingEnemies = Physics.OverlapSphere (
				setTarget.gameObject.transform.position, myWeapon.GetSplash ());
			for (int i = 0; i < overlappingEnemies.Length; i++) {
				overlappingEnemies [i].GetComponent<target> ().DealDamage (damageAry [1], myWeapon.GetDType ());
			}
		} else {
			setTarget.DealDamage (myWeapon.GetDamageCrit[0], myWeapon.GetDType, true);
		}


		cursorController.Get.Finish ();
	}

	public override bool Cancel ()
	{
		cursorController.Get.Finish ();
	}

}