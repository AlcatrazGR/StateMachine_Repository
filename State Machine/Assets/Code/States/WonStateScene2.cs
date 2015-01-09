using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States{

	public class WonStateScene2 : IStateBase{
		private StateManager manager;

		public WonStateScene2 (){

		}

		public void StateUpdate(){
			if (Input.GetKeyUp (KeyCode.Space)) {
				//manager.Restart();
			}
		}

		public void ShowIt(){

		}
	}
}

