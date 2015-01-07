using UnityEngine;
using System.Collections;
using Assets.Code.States;
using Assets.Code.Interfaces;

public class StateManager : MonoBehaviour {
	private IStateBase activeState;

	// Use this for initialization
	void Start () {
		activeState = new BeginState (this);
	}
	
	// Update is called once per frame
	void Update () {
		if (activeState != null)
			activeState.StateUpdate ();
	}

	//The OnGUI method will be called at least once per frame
	void OnGUI(){
		if (activeState != null) {
			activeState.ShowIt();
		}
	}

	//A method which is called from the states in order for
	//them to change the reference.
	public void SwitchState(IStateBase newState){
		activeState = newState;
	}
}
