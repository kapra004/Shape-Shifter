using UnityEngine;
using System.Collections;

public class MakeParallelogram : MonoBehaviour {
	
	
	public void makeParallelogram () 
	{
		transform.Find ("Trapezoid").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Octagon").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Parallelogram").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 4;
	}
}