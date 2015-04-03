using UnityEngine;
using System.Collections;

public class HardStartWall : MonoBehaviour {

	GameObject newWall;
	
	void Start()
	{
		int counter = Random.Range(1,7);
		if (counter == 1)
		{
			newWall = Instantiate(Resources.Load<GameObject>("CircleHoleH"))as GameObject;
			CheckIfCorrect.checkWall = 1;
		}
		if (counter == 2)
		{
			newWall = Instantiate(Resources.Load<GameObject>("SquareHoleH"))as GameObject;
			CheckIfCorrect.checkWall = 2;
		}
		if (counter == 3)
		{
			newWall = Instantiate(Resources.Load<GameObject>("TriangleHoleH"))as GameObject;
			CheckIfCorrect.checkWall = 3;
		}
		if (counter == 4)
		{
			newWall = Instantiate(Resources.Load<GameObject>("ParallelogramHoleH"))as GameObject;
			CheckIfCorrect.checkWall = 4;
		}
		if (counter == 5)
		{
			newWall = Instantiate(Resources.Load<GameObject>("OctagonHoleH"))as GameObject;
			CheckIfCorrect.checkWall = 5;
		}
		if (counter == 6)
		{
			newWall = Instantiate(Resources.Load<GameObject>("TrapezoidHoleH"))as GameObject;
			CheckIfCorrect.checkWall = 6;
		}
	}
}
