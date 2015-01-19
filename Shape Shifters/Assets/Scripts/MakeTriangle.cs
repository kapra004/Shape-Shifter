using UnityEngine;
using System.Collections;

public class MakeTriangle : MonoBehaviour {
	
	MeshRenderer newShape;

	public void makeTriangle () 
	{
		transform.Find ("Triangle").GetComponent<MeshRenderer> ().enabled = true;
		transform.Find ("Square").GetComponent<MeshRenderer> ().enabled = false;
		transform.Find ("Circle").GetComponent<MeshRenderer> ().enabled = false;
		CheckIfCorrect.checkShape = 3;
	}
}
