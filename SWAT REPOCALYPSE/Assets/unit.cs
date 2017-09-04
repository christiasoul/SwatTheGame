using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit : target {

	private float healthMax;
	private float healthCur;
	private float healthHold; // holds float for regen
	private float healthRegen;
	private float energyMax;
	private float energyCur;
	private float energyRegen;



	private float moveSpeed;
	private weapon [] myWeapons;
	private weapon.damageType [] weaknesses;
	private weapon.damageType [] strengths;
	private int armor;

	public bool dealDamage (float damage){
		healthCur -= damage;
		if (Mathf.FloorToInt( healthCur ) <= 0) {
			return true;
		} else {
			return false;
		}
	}

	public bool dealDamage(float damage, int armorPierce , weapon.damageType damType ){
		float mult = 1;
		for (int i = 0; i < weaknesses.Length; i++) {
			if (damType == weaknesses [i]) {
				mult *= 2;
			}
		}
		for (int i = 0; i < strengths.Length; i++) {
			if (damType == strengths.Length){
				mult/2;
			}
		}


		healthCur -= (damage * mult) / Mathf.Pow (1.5, Mathf.Clamp (armor - armorPierce, 0, float.PositiveInfinity));

	}



	

}
