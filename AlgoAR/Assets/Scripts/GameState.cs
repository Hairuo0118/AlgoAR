using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {
	private List<Marker> markers;
	private List<Marker> prevMarkers;
	private List<Marker> waiting;

	void Start () {
		startGame ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void startGame(){
		this.prevMarkers = null;
		/**
		 * find initial marker - use API
		 * call it nextMarker
		 */
	}

	void nextMove(){
		
	}

	void findQueued(){
		Marker leftest = this.markers [this.markers.size()];
		foreach (Marker waitingMarker in waiting){
			
		}
	}
}
