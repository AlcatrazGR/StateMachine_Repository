using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States
{
	public class BeginState : IStateBase{
		private StateManager manager;

		//Constructor
		public BeginState (StateManager managerRef){
			manager = managerRef;
			if (Application.loadedLevelName != "Scene0")
				Application.LoadLevel ("Scene0");
		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState(new SetupState(manager));
			}
		}

		//Method that show a button each time the method OnGUI is called.
		public void ShowIt(){
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), 
			                 manager.gameDataRef.beginStateSplash, ScaleMode.ScaleToFit);
			
			if (GUI.Button (new Rect (10, 10, 250, 60), "Press to Play") || Input.anyKeyDown) {
				manager.SwitchState(new SetupState(manager));
			}

		}

	}
}

