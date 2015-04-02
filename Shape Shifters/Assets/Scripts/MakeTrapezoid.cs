using UnityEngine;
using System.Collections;

public class MakeTrapezoid : MonoBehaviour {

	public void makeTrapezoid()
	{
		transform.Find ("Trapezoid").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Octagon").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Parallelogram").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 6;
	}
}
