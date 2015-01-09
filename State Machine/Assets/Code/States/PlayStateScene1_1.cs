using UnityEngine;
using Assets.Code.Interfaces;
using Assets.Code.States;

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
			/*
			foreach (GameObject camera in manager.gameDataRef.cameras) {
				if(camera.name != "LookAt Camera")
					camera.SetActive(false);
				else
					camera.SetActive(true);
			}
			*/

			if (manager.gameDataRef.playerLives <= 0) {
				manager.SwitchState(new LostStateScene1(manager));
				manager.gameDataRef.ResetPlayer();
				player.rigidbody.isKinematic = true;
				player.transform.position = new Vector3(50, .5f, 40);
			}

			if (manager.gameDataRef.score >= 2) {
				manager.SwitchState(new WonStateScene1(manager));
			}
		}
		
		public void ShowIt(){
			
		}
	}
}

