﻿using UnityEngine;
using System.Collections;

public class MakeSquare : MonoBehaviour {

	
	public void makeSquare() 
	{
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 2;
	}
}