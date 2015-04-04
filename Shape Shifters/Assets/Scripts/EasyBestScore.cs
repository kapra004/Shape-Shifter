using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class EasyBestScore : MonoBehaviour {

	public Text txt;

	void Start()
	{
		GameData.control.Load ();
		txt.text = "Best: Easy: " + GameData.control.highScore;
	}
}
