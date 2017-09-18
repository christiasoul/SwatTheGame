using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class cursorController {

	// Use this for initialization
	private static readonly cursorController instance = new cursorController();
	private static GameObject targCursor;
	private static GameObject myChar;
	private static Camera myCam;
	public static Texture [] myTexAry;
	public static Vector2[] mousePos;
	public const int maxAreaTypes = 1;
	public const int areaCharTarget = 1;

	private cursorController(){}

	public static cursorController Get{
		get{
			return instance;
		}
	}

	public void SetCursor(GameObject newCursor){
		targCursor = newCursor;
	}

	public void ChangeCursorGraphic(int newGraphicNum, int areaType, float radius){
		if (newGraphicNum > -1){
			Cursor.SetCursor (myTexAry [newGraphicNum], mousePos [newGraphicNum], CursorMode.Auto);
		}

		if (areaType > -1 && radius > 0 && areaType < maxAreaTypes) {
			if (areaType < areaCharTarget){
				targCursor.transform.parent = myChar;
			}

			targCursor.GetComponent<cursor> ().SetNumCursor (areaType, radius);

		}

	}

	public void ChangeCursorGraphic(int newGraphicNum){
		if (newGraphicNum > -1){
			Cursor.SetCursor (myTexAry [newGraphicNum], mousePos [newGraphicNum], CursorMode.Auto);
		}

	}

	public void SetCam(Camera newCam){
		myCam = newCam;
	}

	public void SetChar(GameObject newChar){
		myChar = newChar;
	}

	public Quaternion GetCameraCharVector(){
		Event curEvent = Event.current;
		Vector3 screenPoint =  myCam.ScreenToWorldPoint( new Vector3(
			curEvent.mousePosition.x, curEvent.mousePosition.y, myCam.nearClipPlane) );
		return Quaternion.LookRotation (screenPoint - myChar.transform.position);

	}

	public void Finish(){
		targCursor.GetComponent<cursor> ().End ();
		ChangeCursorGraphic (0);
	}

}
