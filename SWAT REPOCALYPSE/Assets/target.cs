using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public abstract class target : MonoBehaviour{

	public enum unitType{UNIT, BACKGROUND, BUILDING, MACHINE, BIOLOGICAL, ITEM, PROP, FLYING, BURIED};
	private bool [] myType;
	private int teamNum; // negative for neutral


	private unitTypeStorage myStorage; 

	public target(unitType [] type, int newTeamNum){
		myType = type;
		teamNum = newTeamNum;
	}

	public unitType [] GetUnitTypes(){
		
	}

	public abstract void DealDamage (float damageAmt, int damageType);

	// Checking will alert the player if they are not able to target them and sound
	public abstract void DealDamage (float damageAmt, int damageType, bool checkingTarget);

	public bool CheckType(unitType check){

		myType [check];

	}


	public int GetTeamNum(){
		return teamNum;
	}

	protected void SetMe(){
		myType = myStorage.GetBools();
	}

	public void Awake(){
		SetMe ();
	}
}

// Used for editor usability to easily modify 
[System.Serializable]
public class unitTypeStorage{
	private bool Unit;
	private bool Background;
	private bool Building;
	private bool Machine;
	private bool Biological;
	private bool Item;
	private bool Prop;
	private bool Flying;
	private bool Buried;

	public bool [] GetBools(){
		return new bool [10] {Unit, Background, Building,
			Machine, Biological, Item, Prop, Flying, Buried};
	}

}