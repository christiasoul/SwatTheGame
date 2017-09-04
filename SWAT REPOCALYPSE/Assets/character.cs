using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : charClass {
	// Use this for initialization
	private abilityStore  [] abilityList;

	private delegate void setOrder(orderInfo myInfo);
	private delegate float orderAction(target setTarget);

	private int [] orderList;
	void Start () {
		
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
		

	private int shootTarget(enemy targEnemy){
		
	}

	private interface attackTypes{

	}

	private class orderInfo{
		private float posX;
		private float posY;
		private target myTarg;
		private ability myAction;


	}


}
