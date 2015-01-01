using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class LostState : IStateBase{
		private StateManager manager;

		//Constructor
		public LostState (StateManager managerRef){
			manager = managerRef;
			Debug.Log ("Constructor of LostState");
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

