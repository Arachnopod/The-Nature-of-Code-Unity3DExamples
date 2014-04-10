// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

// Example 1-3: Vector subtraction

using UnityEngine;
using System.Collections;

public class NOC_1_3_vector_subtraction : MonoBehaviour {
	
	

	void setup()
	{
	}

	
	void Update () {
		
		
		Vector3 mouse = Input.mousePosition;
		mouse = camera.ScreenToViewportPoint(mouse);


		LineRenderer line = GetComponent<LineRenderer>();	
		line.SetPosition(1,camera.ViewportToWorldPoint(new Vector3(mouse.x,mouse.y,20))); // set ending point of line
		

	}
}

