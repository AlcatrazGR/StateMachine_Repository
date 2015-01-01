using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LearningScript : MonoBehaviour {

	// Use this for initialization, it is called only once at the start of the
	//game.
	void Start () {
		Dictionary<int, string> myFavoriteWeapons = new Dictionary<int, string> ();

		myFavoriteWeapons.Add (10, "Dagger");
		myFavoriteWeapons.Add (20, "Katana");
		myFavoriteWeapons.Add (30, "Blund");
		myFavoriteWeapons.Add (40, "Hammer");

		for (int i=10; i<=40; i += 10) {
			Debug.Log("Weapon : "+myFavoriteWeapons[i]);
		}

	}
	
	// Update is called once per frame, it is called every time the frames
	//are changed. Thats a great way to detect mouse click events or keyboard
	//events.
	void Update () {

	}

}
