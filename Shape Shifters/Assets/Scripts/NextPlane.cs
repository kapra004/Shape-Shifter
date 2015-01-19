using UnityEngine;
using System.Collections;

public class NextPlane : MonoBehaviour {
	GameObject newWall;
	bool check = false;

	void Incrementi()
	{
		if (check == true)
		{
			Scoring.i = Scoring.i + 1;
			check = false;
			Destroy(gameObject);
		}
	}

	
	void FixedUpdate () 
	{
		int counter = Random.Range(1,4);
		// Score Parameter
		if (Scoring.i <= 0) 
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.rigidbody.drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.02 && gameObject.transform.position.z > 9.97)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");

				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Remove Drag
			if (gameObject.transform.position.z < 8) 
			{
				gameObject.rigidbody.drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 1.65 && gameObject.transform.position.z > 1.55) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (Scoring.currentscore == 1)
				{
					newWall.constantForce.force = new Vector3 (0, 0, -18);
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 0 && Scoring.i <= 2)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.rigidbody.drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.90)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Remove Drag
			if (gameObject.transform.position.z < 8) 
			{
				gameObject.rigidbody.drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 3.20 && gameObject.transform.position.z > 3.00) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.constantForce.force = new Vector3 (0, 0, -18);
				if (Scoring.currentscore == 3)
				{
					newWall.constantForce.force = new Vector3 (0, 0, -20);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 2 && Scoring.i <= 5)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.rigidbody.drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.90)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Remove Drag
			if (gameObject.transform.position.z < 8) 
			{
				gameObject.rigidbody.drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.90) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.constantForce.force = new Vector3 (0, 0, -20);
				if (Scoring.currentscore == 6)
				{
					newWall.constantForce.force = new Vector3 (0, 0, -22);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 5 && Scoring.i <= 10)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.rigidbody.drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.2 && gameObject.transform.position.z > 9.90)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Remove Drag
			if (gameObject.transform.position.z < 8) 
			{
				gameObject.rigidbody.drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.2 && gameObject.transform.position.z > 9.90) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.constantForce.force = new Vector3 (0, 0, -22);
				if (Scoring.currentscore == 11)
				{
					newWall.constantForce.force = new Vector3 (0, 0, -28);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 10 && Scoring.i <= 15)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.rigidbody.drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.80)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Remove Drag
			if (gameObject.transform.position.z < 8) 
			{
				gameObject.rigidbody.drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.80) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.constantForce.force = new Vector3 (0, 0, -28);
				if (Scoring.currentscore == 16)
				{
					newWall.transform.position = new Vector3 (0, 0, 80);
					newWall.constantForce.force = new Vector3 (0, 0, -40);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 15 && Scoring.i <= 20)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.rigidbody.drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.80)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Remove Drag
			if (gameObject.transform.position.z < 8) 
			{
				gameObject.rigidbody.drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.1 && gameObject.transform.position.z > 9.80) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 80);
				newWall.constantForce.force = new Vector3 (0, 0, -40);
				if (Scoring.currentscore == 21)
				{
					newWall.transform.position = new Vector3 (0, 0, 70);
					newWall.constantForce.force = new Vector3 (0, 0, -45);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 20 && Scoring.i <= 25)
		{
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 70);
				newWall.constantForce.force = new Vector3 (0, 0, -45);
				if (Scoring.currentscore == 26)
				{
					newWall.transform.position = new Vector3 (0, 0, 60);
					newWall.constantForce.force = new Vector3 (0, 0, -50);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 25 && Scoring.i <= 30)
		{
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 60);
				newWall.constantForce.force = new Vector3 (0, 0, -50);
				if (Scoring.currentscore == 31)
				{
					newWall.transform.position = new Vector3 (0, 0, 50);
					newWall.constantForce.force = new Vector3 (0, 0, -60);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 30 && Scoring.i <= 40)
		{
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 50);
				newWall.constantForce.force = new Vector3 (0, 0, -60);
				if (Scoring.currentscore == 41)
				{
					newWall.transform.position = new Vector3 (0, 0, 40);
					newWall.constantForce.force = new Vector3 (0, 0, -75);
				}
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 40)
		{
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					Application.LoadLevel("Game Over");
				}
				else
				{
					Scoring.currentscore = Scoring.currentscore + 1;
					check = true;
				}
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHole"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHole"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHole"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				newWall.transform.position = new Vector3 (0, 0, 40);
				newWall.constantForce.force = new Vector3 (0, 0, -75);
				newWall.rigidbody.drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
	}
}
