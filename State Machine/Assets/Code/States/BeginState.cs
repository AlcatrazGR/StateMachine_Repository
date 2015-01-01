using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class BeginState : IStateBase{
		private StateManager manager;

		//Constructor
		public BeginState (StateManager managerRef){
			manager = managerRef;
			Debug.Log ("Constructing Begin State!");
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

