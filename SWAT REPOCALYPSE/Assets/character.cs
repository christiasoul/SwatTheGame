using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : charClass {
	// Use this for initialization
	private abilityStore  [] abilityAry; // !!! May need to remove

	private delegate void setOrder(orderInfo myInfo);
	//private delegate float orderAction(target setTarget);

	private setOrder [] orderAry;
	void Start () {
	}



	public character(charClass myClass){

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void findTarget(target setTarg){

	}

	public void findTarget(float posX, float posY){

	}

	public void findTarget(){

	}
		

	//private int shootTarget(enemy targEnemy){
		
	//}

	private class orderInfo{
		private float posX;
		private float posY;
		private target myTarg;
		private ability myAction;


	}
		
}
