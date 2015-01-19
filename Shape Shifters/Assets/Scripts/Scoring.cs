using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	Text txt;
	public static int currentscore = 0;
	public static int i = 0;
	void Start()
	{
		txt = gameObject.GetComponent<Text>();
		txt.text="Score: " + currentscore;
	}

	void Update () 
	{
		txt.text = "Score: " + currentscore;
	}
}
