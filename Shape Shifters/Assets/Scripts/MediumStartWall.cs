using UnityEngine;
using System.Collections;

public class MediumStartWall : MonoBehaviour {
	
	GameObject newWall;
	
	void Start()
	{
		int counter = Random.Range(1,5);
		if (counter == 1)
		{
			newWall = Instantiate(Resources.Load<GameObject>("CircleHoleM"))as GameObject;
			CheckIfCorrect.checkWall = 1;
		}
		if (counter == 2)
		{
			newWall = Instantiate(Resources.Load<GameObject>("SquareHoleM"))as GameObject;
			CheckIfCorrect.checkWall = 2;
		}
		if (counter == 3)
		{
			newWall = Instantiate(Resources.Load<GameObject>("TriangleHoleM"))as GameObject;
			CheckIfCorrect.checkWall = 3;
		}
		if (counter == 4)
		{
			newWall = Instantiate(Resources.Load<GameObject>("ParallelogramHoleM"))as GameObject;
			CheckIfCorrect.checkWall = 4;
		}
	}
}
