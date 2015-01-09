using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayStateScene1_1 : IStateBase{

		private StateManager manager;
		private GameObject player;

		public PlayStateScene1_1 (StateManager managerRef){
			manager = managerRef;
			if (Application.loadedLevelName != "Scene1")
				Application.LoadLevel ("Scene1");

			player = GameObject.Find ("Player");
			//Sets the physics properties to the player
			player.rigidbody.isKinematic = false;
		}

		public void StateUpdate(){
			foreach (GameObject camera in manager.gameDataRef.cameras) {
				if(camera.name != "LookAt Camera")
					camera.SetActive(false);
				else
					camera.SetActive(true);
			}
		}
		
		public void ShowIt(){
			
		}
	}
}

