using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class WonState : IStateBase{
		private StateManager manager;

		//Constructor
		public WonState (StateManager managerRef){
			manager = managerRef;
			Debug.Log ("Constructor of WonState");
		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState (new PlayState(manager));
			}
		}
		
		public void ShowIt(){
			
		}
	}
}

