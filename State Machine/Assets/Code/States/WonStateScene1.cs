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
		}

		public void StateUpdate(){
		
		}
		
		public void ShowIt(){
		}

	}
}

