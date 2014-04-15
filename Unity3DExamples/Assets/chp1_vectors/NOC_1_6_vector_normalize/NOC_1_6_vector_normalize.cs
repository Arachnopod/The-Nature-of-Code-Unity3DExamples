// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

// Demonstration of normalizing a vector.
// Normalizing a vector sets its length to 1.

using UnityEngine;
using System.Collections;

public class NOC_1_6_vector_normalize : MonoBehaviour {
	


	void setup()
	{
	}
	
	
	void Update () {
		
				
		Vector3 mouse = camera.ScreenToWorldPoint(Input.mousePosition+new Vector3(0.0f,0.0f,camera.nearClipPlane));
		
		mouse.Normalize();
		mouse*=50;
			
		LineRenderer line = GetComponent<LineRenderer>();	
		line.SetPosition(0,new Vector3(0.0f,0.0f,camera.nearClipPlane+1.0f));
		line.SetPosition(1,mouse);

	}
}

