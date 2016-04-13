// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

// Example 1-4: Vector multiplication

using UnityEngine;
using System.Collections;

public class NOC_1_4_vector_multiplication : MonoBehaviour {


	void setup()
	{
	}

	
	void Update () {
				
		Vector3 mouse = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition+new Vector3(0.0f,0.0f,GetComponent<Camera>().nearClipPlane));
		
		mouse *= 0.5f;
		
		LineRenderer line = GetComponent<LineRenderer>();	
		line.SetPosition(0,new Vector3(0.0f,0.0f,GetComponent<Camera>().nearClipPlane+1.0f));
		line.SetPosition(1,mouse);

	}
}

