using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayStateScene1_1 : IStateBase{

		private StateManager manager;

		public PlayStateScene1_1 (StateManager managerRef){
			manager = managerRef;
		}

		public void StateUpdate(){
		}
		
		public void ShowIt(){
			
		}
	}
}

