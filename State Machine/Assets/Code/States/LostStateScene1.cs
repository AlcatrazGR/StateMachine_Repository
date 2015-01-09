using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

namespace Assets.Code.States
{
	public class LostStateScene1 : IStateBase{
		private StateManager manager;
		public LostStateScene1 (StateManager managerRef){
			manager = managerRef;
		}

		public void StateUpdate(){

		}
		
		public void ShowIt(){
			
		}
	}
}

