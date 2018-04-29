using UnityEngine;
using System.Collections;

public class DotsSpawner : MonoBehaviour {


public Camera myCamera;
private GameObject dotsParents;
public GameObject dot;

	void Start (){
	
		dotsParents = GameObject.Find("DOTS");
		
		if (!dotsParents){
			dotsParents = new GameObject("DOTS");
		}
		
	}

void OnMouseDown (){
		Vector2 dotPosition = CalculateWorldPointOfMouseClick ();
		float randomRotation = Random.value * 360;
		Quaternion ZeroRot = Quaternion.AngleAxis(randomRotation, Vector3.back);
		
		GameObject newDot = Instantiate (dot, dotPosition, ZeroRot) as GameObject;
		newDot.transform.parent = dotsParents.transform;
		
	}
	
	Vector2 CalculateWorldPointOfMouseClick (){
	float mouseX = Input.mousePosition.x;
	float mouseY = Input.mousePosition.y;
	float distanceFromCamera = 10f;
	
	Vector3 weirdTriplet = new Vector3 (mouseX, mouseY, distanceFromCamera);
	Vector2 worldPos = myCamera.ScreenToWorldPoint (weirdTriplet);
	
	return worldPos;
	
	 } 
}
