using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {
	private GameObject targetChild;
	// Use this for initialization
	void Start () {
		cursorController.Get.SetCursor (gameObject);
		enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (targetChild != null) {
			targetChild.transform.rotation = cursorController.Get.GetCameraCharVector ();
		}
	}

	public void SetNumCursor(int childNum){
		targetChild = transform.GetChild (childNum);
		targetChild.activeInHierarchy = true;
		enabled = true;
	}

	public void SetNumCursor(int childNum, float radius){
		targetChild = transform.GetChild (childNum);
		targetChild.transform.lossyScale = radius;
		targetChild.activeInHierarchy = true;
		enabled = true;
	}

	public void End(){
		enabled = true;
		targetChild.activeInHierarchy = false;
		targetChild = null;
	}

}