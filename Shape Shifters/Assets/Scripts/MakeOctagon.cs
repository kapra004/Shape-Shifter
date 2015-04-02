using UnityEngine;
using System.Collections;

public class MakeOctagon : MonoBehaviour {
	
	
	public void makeOctagon () 
	{
		transform.Find ("Trapezoid").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Octagon").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Parallelogram").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 5;
	}
}
