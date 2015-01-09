using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	public float setupSpinSpeed = 50.0f;
	public float speed = 16.0f;
	public float rotationSpeed = 0.60f;
	public float hoverPower = 3.5f;

	public Rigidbody projectile;
	
	public Color red = Color.red;
	public Color blue = Color.blue;
	public Color green = Color.green;
	public Color yellow = Color.yellow;
	public Color white = Color.white;

	private GameData gameDataRef;

	void FixedUpdate(){
		float foreAndAft = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		rigidbody.AddRelativeForce (0, 0, foreAndAft);
		rigidbody.AddTorque (0, rotation, 0);
	}

	void OnTriggerStay(Collider other){
		rigidbody.AddForce (Vector3.up * hoverPower);
	}

	// Use this for initialization
	void Start () {
		gameDataRef = GameObject.Find ("GameManager").GetComponent<GameData> ();
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
