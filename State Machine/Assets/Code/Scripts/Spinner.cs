using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {

	public void SpinLeft(){
		//The Time.deltaTime means 1 per second
		//The Rotate function of the transform causes the object to
		//spin on Z-axis.
		transform.Rotate (0, 0, 60 * Time.deltaTime);
	}

	public void SpinRight(){
		//The Time.deltaTime means 1 per second
		//The Rotate function of the transform causes the object to
		//spin on Z-axis.
		transform.Rotate (0, 0, -60 * Time.deltaTime);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
