using UnityEngine;
using System.Collections;

public class HardPlayGame : MonoBehaviour {

	public void  playFunction()
	{
		Application.LoadLevel("Hard Game Mode");
		Scoring.currentscore = 0;
		Scoring.i = 0;
		CheckIfCorrect.checkShape = 2;
	}
}
