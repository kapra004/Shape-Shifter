using UnityEngine;
using System.Collections;

public class MakeSquare : MonoBehaviour {

	
	public void makeSquare() 
	{
		transform.Find ("Trapezoid").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Octagon").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Parallelogram").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 2;
	}
}
