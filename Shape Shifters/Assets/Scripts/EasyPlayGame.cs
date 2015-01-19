using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EasyPlayGame : MonoBehaviour {
	
	public void  playFunction()
	{
		Application.LoadLevel("Easy Game Mode");
		Scoring.currentscore = 0;
		Scoring.i = 0;
		CheckIfCorrect.checkShape = 2;
	}
}
