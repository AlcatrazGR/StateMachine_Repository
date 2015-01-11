using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;
using System;

namespace Assets.Code.States
{
	public class WonStateScene1 : IStateBase{
		private StateManager manager;

		public WonStateScene1 (StateManager managerRef){
			manager = managerRef;
			if (Application.loadedLevelName != "Scene0")
				Application.LoadLevel ("Scene0");
			manager.gameDataRef.SetScore ();
		}

		public void StateUpdate(){
		
		}
		
		public void ShowIt(){
		}

	}
}

