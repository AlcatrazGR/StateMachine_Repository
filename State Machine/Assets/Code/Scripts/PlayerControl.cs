using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float setupSpinSpeed = 50.0f;

	public Color red = Color.red;
	public Color blue = Color.blue;
	public Color green = Color.green;
	public Color yellow = Color.yellow;
	public Color white = Color.white;
	
	// Use this for initialization
	void Start () {
	
	}

	public void PlayerUpdate(){

	}

	// Update is called once per frame
	void Update () {
	
	}

	public void PickedColor(Color playerColor){
		renderer.material.color = playerColor;
	}
}
