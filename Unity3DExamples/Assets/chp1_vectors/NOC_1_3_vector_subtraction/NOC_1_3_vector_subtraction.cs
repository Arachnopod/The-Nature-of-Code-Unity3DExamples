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
		
		// Although the folloing code gets the same results as the Processing example, it is not using any Vector Substaction
		// if anybody has any idea how to implement vector substraction to make this example relative to the book, please let me know
				
		Vector3 mouse = camera.ScreenToWorldPoint(Input.mousePosition+new Vector3(0.0f,0.0f,camera.nearClipPlane));

		LineRenderer line = GetComponent<LineRenderer>();	
		line.SetPosition(0,new Vector3(0.0f,0.0f,camera.nearClipPlane+1.0f));
		line.SetPosition(1,mouse);

	}
}

