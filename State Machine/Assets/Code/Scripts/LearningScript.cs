using UnityEngine;
using System.Collections;

public class LearningScript : MonoBehaviour {
	public HingeJoint[] hingeJoints;

	// Use this for initialization, it is called only once at the start of the
	//game.
	void Start () {
		hingeJoints = gameObject.GetComponent<HingeJoint> ();

		for (int i=0; i<hingeJoints.Length(); i++) {
			Debug.Log(hingeJoints[i]);
		}
	}
	
	// Update is called once per frame, it is called every time the frames
	//are changed. Thats a great way to detect mouse click events or keyboard
	//events.
	void Update () {

	}

}
