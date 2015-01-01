using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LearningScript : MonoBehaviour {
	GameObject capsuleGO;
	Spinner cubeComp;

	// Use this for initialization, it is called only once at the start of the
	//game.
	void Start () {
		capsuleGO = GameObject.Find ("Capsule");
		Debug.Log (capsuleGO);

		cubeComp = GameObject.Find ("Cube").GetComponent<Spinner>();
		Debug.Log (cubeComp);
	}
	
	// Update is called once per frame, it is called every time the frames
	//are changed. Thats a great way to detect mouse click events or keyboard
	//events.
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			capsuleGO.GetComponent<Spinner>().SpinLeft();
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			capsuleGO.GetComponent<Spinner>().SpinRight();
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			cubeComp.SpinLeft();
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			cubeComp.SpinRight();
		}
	}

}
