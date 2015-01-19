using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	Text txt;

	void Start () 
	{
		txt = gameObject.GetComponentInChildren<Text> ();
		txt.text = "Your Score: " + Scoring.currentscore;
	}
}
