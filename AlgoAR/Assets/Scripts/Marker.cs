using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour {

	public enum MarkerStatus{
		QUEUED,
		CORRECT,
		WRONG
	}

	// Initialization of xyz will be added when 
	private int x;
	private int y;
	private int z;

	private int displayVal;
	private int cardIndex;

	MarkerStatus status = MarkerStatus.QUEUED;

	void Start () {
		
	}

	void Update () {
		//Constantly update the xyz of the marker by looking through the tracking number
	}


}
