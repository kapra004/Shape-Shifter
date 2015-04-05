using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	public Text txt;

	void Start () 
	{
		txt.text = "Your Score: " + Scoring.currentscore;
	}
}
