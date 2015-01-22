using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseDifficulty : MonoBehaviour {
	void Start(){
		GooglePlayController.googlePlay.SignIn ();

	}
	public void  loadFunction()
	{
		Application.LoadLevel("Choose Difficulty");
	}
	public void showLeaderboard(){
		GooglePlayController.googlePlay.SignIn ();
		GooglePlayController.googlePlay.UpdateLeaderboard (GameData.control.highScore);
		GooglePlayController.googlePlay.ShowLeaderboard ();
	}
}

