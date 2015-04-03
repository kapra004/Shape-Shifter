using UnityEngine;
using System.Collections;

public class MakeTriangle : MonoBehaviour {

	public void makeTriangle () 
	{
		transform.Find ("Trapezoid").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Octagon").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Parallelogram").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 3;
	}
}
