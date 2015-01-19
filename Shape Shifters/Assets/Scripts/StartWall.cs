using UnityEngine;
using System.Collections;

public class StartWall : MonoBehaviour {

	GameObject newWall;

	void Start()
	{
		int counter = Random.Range(1,4);
		if (counter == 1)
		{
			newWall = Instantiate(Resources.Load<GameObject>("CircleHole"))as GameObject;
			CheckIfCorrect.checkWall = 1;
		}
		if (counter == 2)
		{
			newWall = Instantiate(Resources.Load<GameObject>("SquareHole"))as GameObject;
			CheckIfCorrect.checkWall = 2;
		}
		if (counter == 3)
		{
			newWall = Instantiate(Resources.Load<GameObject>("TriangleHole"))as GameObject;
			CheckIfCorrect.checkWall = 3;
		}
	}
}
