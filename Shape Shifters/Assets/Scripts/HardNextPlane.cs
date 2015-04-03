using UnityEngine;
using System.Collections;

public class HardNextPlane : MonoBehaviour {
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
		int counter = Random.Range(1,7);
		// Score Parameter
		if (Scoring.i <= 0) 
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.GetComponent<Rigidbody>().drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.02 && gameObject.transform.position.z > 9.97)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
				gameObject.GetComponent<Rigidbody>().drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 1.65 && gameObject.transform.position.z > 1.55) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				if (Scoring.currentscore == 1)
				{
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -18);
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.GetComponent<Rigidbody>().drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 0 && Scoring.i <= 1)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.GetComponent<Rigidbody>().drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 9.98 && gameObject.transform.position.z > 9.85)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
				gameObject.GetComponent<Rigidbody>().drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 3.20 && gameObject.transform.position.z > 3.00) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -18);
				if (Scoring.currentscore == 2)
				{
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -20);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 1 && Scoring.i <= 2)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.GetComponent<Rigidbody>().drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.90)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
				gameObject.GetComponent<Rigidbody>().drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.90) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -20);
				if (Scoring.currentscore == 3)
				{
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -22);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 2 && Scoring.i <= 4)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.GetComponent<Rigidbody>().drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.2 && gameObject.transform.position.z > 9.90)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
				gameObject.GetComponent<Rigidbody>().drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.2 && gameObject.transform.position.z > 9.90) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -22);
				if (Scoring.currentscore == 5)
				{
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -28);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 4 && Scoring.i <= 8)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.GetComponent<Rigidbody>().drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.80)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
				gameObject.GetComponent<Rigidbody>().drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.80) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 100);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -28);
				if (Scoring.currentscore == 9)
				{
					newWall.transform.position = new Vector3 (0, 0, 80);
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -40);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 8 && Scoring.i <= 15)
		{
			// Add Drag
			if (gameObject.transform.position.z < 20) 
			{
				gameObject.GetComponent<Rigidbody>().drag = 5;		
			}
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.0 && gameObject.transform.position.z > 9.80)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
				gameObject.GetComponent<Rigidbody>().drag = 0;
			}
			// Create New Wall
			if (gameObject.transform.position.z < 10.1 && gameObject.transform.position.z > 9.80) 
			{
				if (counter == 1) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 80);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -40);
				if (Scoring.currentscore == 16)
				{
					newWall.transform.position = new Vector3 (0, 0, 70);
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -45);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
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
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 70);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -45);
				if (Scoring.currentscore == 21)
				{
					newWall.transform.position = new Vector3 (0, 0, 60);
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -50);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
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
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 60);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -50);
				if (Scoring.currentscore == 26)
				{
					newWall.transform.position = new Vector3 (0, 0, 50);
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -60);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
				newWall.name = "Wall";
			}
			// Delete Current Wall and Increment i
			if (gameObject.transform.position.z < 1)
			{
				Incrementi();
			}
		}
		// Next Score Parameter
		if (Scoring.i > 25 && Scoring.i <= 40)
		{
			// Check if Correct and Add Score
			if (gameObject.transform.position.z < 10.5 && gameObject.transform.position.z > 10.0)
			{
				if (CheckIfCorrect.checkWall != CheckIfCorrect.checkShape)
				{
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 50);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -60);
				if (Scoring.currentscore == 41)
				{
					newWall.transform.position = new Vector3 (0, 0, 40);
					newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -75);
				}
				newWall.GetComponent<Rigidbody>().drag = 0;
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
					if(Scoring.currentscore == GameData.control.hardHighScore)
					{
						GameData.control.hardSave ();
					}
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
					newWall = Instantiate (Resources.Load<GameObject> ("CircleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 1;
				}
				if (counter == 2) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("SquareHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 2;
				}
				if (counter == 3) 
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TriangleHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 3;
				}
				if (counter == 4)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("ParallelogramHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 4;
				}
				if (counter == 5)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("OctagonHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 5;
				}
				if (counter == 6)
				{
					newWall = Instantiate (Resources.Load<GameObject> ("TrapezoidHoleH"))as GameObject;
					CheckIfCorrect.checkWall = 6;
				}
				newWall.transform.position = new Vector3 (0, 0, 40);
				newWall.GetComponent<ConstantForce>().force = new Vector3 (0, 0, -75);
				newWall.GetComponent<Rigidbody>().drag = 0;
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