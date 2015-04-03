using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	public Text txt;

	void Start()
	{
		GameData.control.Load ();
		txt.text = "High Score: " + GameData.control.highScore;
	}

	void Update()
	{
		if (Scoring.currentscore > GameData.control.highScore)
		{
			GameData.control.highScore = Scoring.currentscore;
			txt.text = "High Score: " + GameData.control.highScore;
		}
	}
}
