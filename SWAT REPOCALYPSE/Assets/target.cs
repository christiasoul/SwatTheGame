using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class target{

	private GameObject self;
	public enum unitType{UNIT, BACKGROUND, BUILDING, MACHINE, BIOLOGICAL};
	private unitType [] myType;
	private int teamNum;

	public target(GameObject target, unitType [] type, int teamNum){
		myType = type;
		self = target;


	}

	public unitType [] GetUnitTypes(){
		return myType;
	}

	public int getTeamNum(){
		return teamNum;
	}


}