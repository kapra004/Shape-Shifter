using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class MediumHighScore : MonoBehaviour {
	
	public Text txt;
	
	void Start()
	{
		GameData.control.medLoad ();
		txt.text = "High Score: " + GameData.control.medHighScore;
	}
	
	void Update()
	{
		if (Scoring.currentscore > GameData.control.medHighScore)
		{
			GameData.control.medHighScore = Scoring.currentscore;
			txt.text = "High Score: " + GameData.control.medHighScore;
		}
	}
}
