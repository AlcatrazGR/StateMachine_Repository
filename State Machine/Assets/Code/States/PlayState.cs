using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayState : IStateBase{
		private StateManager manager;

		//Constructor		
		public PlayState (StateManager managerRef){
			manager = managerRef;
			Debug.Log ("Constructor of PlayState");
		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState (new WonState(manager));
			}

			if (Input.GetKeyUp (KeyCode.Return)) {
				manager.SwitchState(new LostState(manager));			
			}
		}
		
		public void ShowIt(){
			
		}

	}
}

