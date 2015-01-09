using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayStateScene1_2 : IStateBase{
		
		private StateManager manager;
		private GameObject player;

		public PlayStateScene1_2 (StateManager managerRef){
			manager = managerRef;
		}

		public void StateUpdate(){
			foreach (GameObject camera in manager.gameDataRef.cameras) {
				if(camera.name != "Following Camera")
					camera.SetActive(false);
				else
					camera.SetActive(true);
			}
		}
		
		public void ShowIt(){
			
		}
	}
}

