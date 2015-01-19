using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MediumPlayGame : MonoBehaviour {
	
	public void  playFunction()
	{
		Application.LoadLevel("Medium Game Mode");
		Scoring.currentscore = 0;
		Scoring.i = 0;
		CheckIfCorrect.checkShape = 2;
	}
}

