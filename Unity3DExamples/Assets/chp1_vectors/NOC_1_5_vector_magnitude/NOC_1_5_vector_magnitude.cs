// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

// Example 1-5: Vector magnitude

using UnityEngine;
using System.Collections;

public class NOC_1_5_vector_magnitude : MonoBehaviour {
	
	public Transform rect;

	void setup()
	{
	}
	
	
	void Update () {
		
				
		Vector3 mouse = camera.ScreenToWorldPoint(Input.mousePosition+new Vector3(0.0f,0.0f,camera.nearClipPlane));
		
		
		float m = mouse.magnitude;
		print (m);
		rect.transform.localScale = new Vector3(m,1,1);
		
			
		LineRenderer line = GetComponent<LineRenderer>();	
		line.SetPosition(0,new Vector3(0.0f,0.0f,camera.nearClipPlane+1.0f));
		line.SetPosition(1,mouse);

	}
}

