// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

// Example 1-2: Bouncing Ball, with Vector

using UnityEngine;
using System.Collections;

public class NOC_1_2_bouncingball_vectors : MonoBehaviour {
	
	
	public Transform target;	//GameObject to bounce around
	private Vector3 location = new Vector3(0.5f,0.5f,20.0f);	// position of GameObject
	private Vector3 velocity = new Vector3(0.01f,0.02f,0.0f);	//speed of GameObject
	
	void setup()
	{
	}
	
	void Update () {
	
		// Add the current speed to the location.
		location = location + velocity;
		
		if (location.x > 1 || location.x < 0){
			velocity.x = velocity.x * -1.0f;
		}
		if (location.y > 1 || location.y < 0){
			velocity.y = velocity.y * -1.0f;
		}
		
		// Display GameObject at x location
		target.position = camera.ViewportToWorldPoint(new Vector3(location.x,location.y,location.z));
	}
}

