using UnityEngine;
using System.Collections;

public class HardStartWall : MonoBehaviour {

	GameObject newWall;
	
	void Start()
	{
		int counter = Random.Range(1,7);
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
		if (counter == 4)
		{
			newWall = Instantiate(Resources.Load<GameObject>("ParallelogramHole"))as GameObject;
			CheckIfCorrect.checkWall = 4;
		}
		if (counter == 5)
		{
			newWall = Instantiate(Resources.Load<GameObject>("OctagonHole"))as GameObject;
			CheckIfCorrect.checkWall = 5;
		}
		if (counter == 6)
		{
			newWall = Instantiate(Resources.Load<GameObject>("TrapezoidHole"))as GameObject;
			CheckIfCorrect.checkWall = 6;
		}
	}
}
