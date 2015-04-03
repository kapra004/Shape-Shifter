using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class HardHighScore : MonoBehaviour {
	
	public Text txt;
	
	void Start()
	{
		GameData.control.hardLoad ();
		txt.text = "High Score: " + GameData.control.hardHighScore;
	}
	
	void Update()
	{
		if (Scoring.currentscore > GameData.control.hardHighScore)
		{
			GameData.control.hardHighScore = Scoring.currentscore;
			txt.text = "High Score: " + GameData.control.hardHighScore;
		}
	}
}