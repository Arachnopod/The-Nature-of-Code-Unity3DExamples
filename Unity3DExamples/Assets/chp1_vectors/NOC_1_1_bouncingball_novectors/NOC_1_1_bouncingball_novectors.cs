// The Nature of Code
// Daniel Shiffman
// http://natureofcode.com

// Converted to C# for Unity 3D 3.5.7
// Joseph Fiola
// http://www.joefiola.com

// Example 1-1: Bouncing Ball, no vectors

using UnityEngine;
using System.Collections;

public class NOC_1_1_bouncingball_novectors : MonoBehaviour {
	
	
	public Transform target;		//GameObject to bounce around
	private float x = 0.5f;			//x position of GameObject
	private float y = 0.5f;			//y position of GameObject
	private float z = 20.0f;		//z position of GameObject
	public float xspeed = 0.0f;		//adjust x speed in editor inspector window 
	public float yspeed = 0.0f;		//adjust y speed in editor inspector window 
	
	void setup()
	{
	}

	
	void Update () {
	
		// Add the current speed to the location.
		x = x + xspeed;
		y = y + yspeed;
		


		if (x > 1 || x < 0){
			xspeed = xspeed * -1.0f;
		}
		if (y > 1 || y < 0){
			yspeed = yspeed * -1.0f;
		}
		
		// Display GameObject at x location
		target.position = camera.ViewportToWorldPoint(new Vector3(x,y,z));
	}
}

