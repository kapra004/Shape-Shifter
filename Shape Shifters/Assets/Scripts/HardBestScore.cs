using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class HardBestScore : MonoBehaviour {

	public Text txt;

	void Start()
	{
		GameData.control.hardLoad ();
		txt.text = "Hard: " + GameData.control.hardHighScore;
	}
}

