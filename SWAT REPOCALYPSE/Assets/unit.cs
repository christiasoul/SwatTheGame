using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unit : target {

	protected float healthMax;
	protected float healthCur;
	protected float healthHold; // holds float for regen
	protected float healthRegen;
	protected float energyMax;
	protected float energyCur;
	protected float energyRegen;

	protected float timeUnavailable = 0;
	protected bool available = true;

	protected float moveSpeed;
	protected weaponHeld [] myWeapons;
	protected weaponHeld.damageType [] weaknesses;
	protected weaponHeld.damageType [] strengths;
	protected int armor;

	public bool dealDamage (float damage){
		healthCur -= damage;
		if (Mathf.FloorToInt( healthCur ) <= 0) {
			return true;
		} else {
			return false;
		}
	}

	public bool dealDamage(float damage, int armorPierce , weaponHeld.damageType damType ){
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

	public bool isAvailable(){
		return available;
	}
	public void setAvailable(){
		available = true;
	}
	public void setNotAvailable(){
		available = false;
	}
	

}
