using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwitchCanvas : MonoBehaviour {

	public GameObject mainCanvas;
	public GameObject helpCanvas;
	public GameObject pSystem1;
	public GameObject pSystem2;
	public GameObject pSystem3;

	public void disableCanvas()
	{
		mainCanvas.SetActive (false);
		pSystem1.SetActive (false);
		pSystem2.SetActive (false);
		pSystem3.SetActive (false);
		helpCanvas.SetActive (true);

	}

	public void enableCanvas()
	{
		helpCanvas.SetActive (false);
		mainCanvas.SetActive (true);
		pSystem1.SetActive (true);
		pSystem2.SetActive (true);
		pSystem3.SetActive (true);
	}

}
