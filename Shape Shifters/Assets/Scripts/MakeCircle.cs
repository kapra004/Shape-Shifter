using UnityEngine;
using System.Collections;

public class MakeCircle : MonoBehaviour {

	
	public void makeCircle () 
	{
		transform.Find ("Trapezoid").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Octagon").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Parallelogram").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = true;
		CheckIfCorrect.checkShape = 1;
	}
}
