using UnityEngine;
using System.Collections;
using Assets.Code.States;
using Assets.Code.Interfaces;

public class StateManager : MonoBehaviour {
	private IStateBase activeState;

	//This is a unity attribute that will prevent the public variable
	//to be displayed in the inspector.
	[HideInInspector]
	//Variable that will store all the components of the game manager
	public GameData gameDataRef;

	//This variable stores a stateManager reference. Its private
	//so it can be used only inside StateManager and static so
	//that the first reference will be the one which will be shared
	//and no otheer reference will tak its place
	private static StateManager instanceRef;

	void Awake(){
		if (instanceRef == null) {
			//The instance reference gets the reference of this class.
			instanceRef = this;
			//This function this classes variables wont be destroied after
			//the change of scenes.
			DontDestroyOnLoad(gameObject);
		} else {
			//When a second copy of the reference of this class is made
			//then it is imidiately been destroied
			DestroyImmediate(gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		activeState = new BeginState (this);
		gameDataRef = GetComponent<GameData> ();
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

	public void Restart(){
		Destroy (gameObject);
		Application.LoadLevel ("Scene0");
	}
}
