using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class BeginState : IStateBase{
		private StateManager manager;
		private float futureTime = 0;
		private int countDown = 0;
		private float ScreenDuration = 8;

		//Constructor
		public BeginState (StateManager managerRef){
			manager = managerRef;
			futureTime = ScreenDuration + Time.realtimeSinceStartup;
			//The line below set the timeScale to 0 so the scenes is 
			//generally paused.
			Time.timeScale = 0;
		}

		public void StateUpdate(){
			float rightNow = Time.realtimeSinceStartup;
			countDown = (int)futureTime - (int)rightNow;

			if (Input.GetKeyUp (KeyCode.Space) || countDown <= 0) {
				Switch();
			}
		}

		//Method that show a button each time the method OnGUI is called.
		public void ShowIt(){
			if (GUI.Button (new Rect (10, 10, 150, 100), "Press to Play")) {
				Switch();
			}

			GUI.Box (new Rect(Screen.width - 60,10,50,25), countDown.ToString());
		}

		void Switch(){
			//The line below set the speed of the game to run normally.
			Time.timeScale = 1;
			manager.SwitchState (new PlayState (manager));
		}
	}
}

