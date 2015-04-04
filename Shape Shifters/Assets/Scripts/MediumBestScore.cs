using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class MediumBestScore : MonoBehaviour {

	public Text txt;

	void Start()
	{
		GameData.control.medLoad ();
		txt.text = "Medium: " + GameData.control.medHighScore;
	}
}