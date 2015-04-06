using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChooseDifficulty : MonoBehaviour {
	void Start()
	{

	}
	public void  chooseDifficulty()
	{
		Application.LoadLevel("Choose Difficulty");
	}

}

